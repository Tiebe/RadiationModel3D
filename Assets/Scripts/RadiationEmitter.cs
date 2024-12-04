using System;
using System.Collections.Generic;
using System.Linq;
using RadiationModel;
using RadiationModel.statistics;
using UnityEngine;
using UnityEngine.Serialization;

public class RadiationEmitter : MonoBehaviour
{

    [FormerlySerializedAs("amount")] public long initalAmount;
    public string radioactiveSubstanceName;
    public bool emitting;
    public bool debugRender = false;
    public bool debugRenderAll = false;
    [HideInInspector]
    public bool resetter = false;

    private Dictionary<RadioactiveSubstance, long> particles = new();
    private void OnEnable()
    {
        if (emitting) Emit();
    }

    private void OnDisable()
    {
        particles.Clear();
    }

    public void Emit()
    {
        var substance = Substances.GetSubstanceByName(radioactiveSubstanceName);
        particles.Add(substance, initalAmount);
    }

    private void ResetEmitter()
    {
        particles.Clear();
        Emit();
        resetter = false;
    }
    
    private (List<KeyValuePair<GameObject, Vector3[]>> hitPoints, Vector3 direction) GetHitPoints()
    {
        var origin = transform.position;
        var direction = UnityEngine.Random.onUnitSphere;

        //var direction = new Vector3(0, 0, 1);
        var ray = new Ray(origin, direction);
        // ReSharper disable once Unity.PreferNonAllocApi
        var hits = Physics.RaycastAll(ray).ToList();
        // sort hits by distance
        hits.Sort((hit1, hit2) => hit1.distance.CompareTo(hit2.distance));
            
        if (hits.Count == 0)
        {
            // renders green lines for debugging
            if (debugRenderAll)
            {
                Debug.DrawRay(transform.position, direction * 50, Color.green, 0.1f);
            }
                
            return (new List<KeyValuePair<GameObject, Vector3[]>>(), direction);
        }
            
        // furthest hit
        var lastHit = hits.Last();
        // remove last hit from hits, as we will not be hitting this again on the way back
        hits.RemoveAt(hits.Count - 1);
        // send ray from last hit to origin
        var lastRay = new Ray(lastHit.point, origin - lastHit.point);
            
        // ReSharper disable once Unity.PreferNonAllocApi
        var returningHits = Physics.RaycastAll(lastRay).ToList();
        // sort hits by distance
        returningHits.Sort((hit1, hit2) => hit1.distance.CompareTo(hit2.distance));
            
        List<KeyValuePair<GameObject, Vector3[]>> hitPoints = new();
            
        for (var j = hits.Count - 1; j >= 0; j--)
        {
            var entryHit = hits[hits.Count - 1 - j];
            var exitHit = returningHits[j];
                
            hitPoints.Add(new KeyValuePair<GameObject, Vector3[]>(entryHit.collider.gameObject, new[] {entryHit.point, exitHit.point}));
        }
        
        // add last hit to hit points, since it will not be hit again on the way back
        hitPoints.Add(new KeyValuePair<GameObject, Vector3[]>(lastHit.collider.gameObject, new[] {lastHit.point, lastHit.point}));

        return (hitPoints, direction);
    }
    
    public static bool HasGammaAbsorbed(GammaParticle gammaParticle, double distance, double massAttenuationCoefficient)
    {
        var attenuation = Math.Exp(-massAttenuationCoefficient * distance);
        var absorbed = 1 - attenuation;
        
        return UnityEngine.Random.value >= absorbed;
    }
    
    public static bool HasBetaAbsorbed(BetaParticle betaParticle, double distance, double massStoppingPower, double density)
    {
        // mass thickness in g/cm^2
        var massThickness = density/1000 * distance;

        var energyLost = massStoppingPower * massThickness;
        betaParticle.energy -= energyLost;

        // only return false if the particle still has energy left
        return betaParticle.energy <= 0;
    }

    private bool HasParticleBeenAbsorbed(GameObject hitGameObject, Vector3[] points, RadioactiveSubstance particle, Vector3 direction)
    {
        // get entry and exit points, and do quick check if exit point is zero
        var (entryPoint, exitPoint) = (points[0], points[1]);
        if (exitPoint.Equals(Vector3.zero)) Debug.Log("No exit point found. Is the collider configured correctly?");
        
        // get distance traveled through material in cm
        var distance = Vector3.Distance(entryPoint, exitPoint) * 100;
        // if distance is zero, the particle can never be absorbed
        if (distance == 0) return false;
                        
        // get material of hit object
        var material = RadiationModelMaterial.GetRadiationModelMaterial(hitGameObject);
                        
        // only run absorption if material is defined
        if (material is null) return false;
        
        switch (particle)
        {
            case GammaParticle gammaParticle when HasGammaAbsorbed(gammaParticle, distance, material.material.GetMACForEnergy(gammaParticle.energy)):
            case BetaParticle electronParticle when HasBetaAbsorbed(electronParticle, distance, material.material.GetMSPForEnergy(electronParticle.energy), material.material.density):
                if (debugRender) Debug.DrawRay(transform.position, direction * distance, Color.red, 0.2f);
                return true;
        }

        return false;
    }

    private void SimulateParticle(RadioactiveSubstance particle)
    {
        // give beta particles a random energy for absorption
        if (particle is BetaParticle betaParticle)
        {
            betaParticle.energy = Statistics.RandomBetaEnergy(betaParticle.spectrum);
        }
                    
        var (hitPoints, direction) = GetHitPoints();

        var hasBeenAbsorbed = false;
                        
        foreach (var (hitGameObject, points) in hitPoints)
        {
            if (HasParticleBeenAbsorbed(hitGameObject, points, particle, direction))
            {
                hasBeenAbsorbed = true;
                break;
            }
                        
            // check if the hit object has a radiation receiver, and if so, call the radiation hit function
            if (!RadiationReceiver.radiationReceivers.TryGetValue(hitGameObject, out var receiver)) continue;
            receiver.RadiationHit(particle);

            if (!debugRender) continue;
            var distanceSinceStart = Vector3.Distance(transform.position, points[0]);
            Debug.DrawRay(transform.position, direction * distanceSinceStart, Color.blue, 0.2f);
        }
                        
        // show the ray if the particle has not been absorbed
        if (debugRenderAll && !hasBeenAbsorbed)
        {
            Debug.DrawRay(transform.position, direction * 50, Color.green, 0.2f);
        }
    }

    private void FixedUpdate()
    {
        if (resetter)
        {
            ResetEmitter();
            return;
        }

        if (!emitting) return;
        
        double time = Time.deltaTime;

        // create copy of particles dictionary to iterate over, since editing a dictionary that is currently being iterated over, throws an error
        var particlesCopy = particles.ToDictionary(entry => entry.Key, entry => entry.Value);
    
        // iterate over all items in the copy of the dictionary
        foreach (var (substance, amount) in particlesCopy) {
            // initiate variables, calculate the decay product and writes it to particles
            var decayed = Statistics.Decay(substance, amount, time);
            particles[substance] = 0;
            foreach (var (particle, particleAmount) in decayed)
            {
                // if the particle is not a gamma or beta particle, add the new particles to the dictionary for the next run
                if (particle is not (GammaParticle or BetaParticle))
                {
                    particles.TryGetValue(particle, out var existing);
                    particles[particle] = existing + particleAmount;
                    continue;
                }
                
                
                for (var i = 0; i < particleAmount; i++)
                {
                    SimulateParticle(particle);
                }
            }
        }

    }
}

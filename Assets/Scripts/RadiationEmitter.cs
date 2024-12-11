using System;
using System.Collections.Generic;
using System.Linq;
using RadiationModel;
using RadiationModel.statistics;
using RadiationModel.substances;
using UnityEngine;

[Serializable]
public struct StartingSubstance
{
    public string name;
    public long amount;
}

public class RadiationEmitter : MonoBehaviour
{
    public bool emitting;
    public bool debugRender = false;
    public bool debugRenderAll = false;
    public List<StartingSubstance> startingSubstancesList = new();
    public bool preRun = false;
    public long preRunFor = 0;
    public float preRunInterval = 1;
    public bool onlyPreRun = false;

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
        particles.Clear();
        foreach (var startingSubstance in startingSubstancesList)
        {
            particles.Add(Substances.GetSubstanceByName(startingSubstance.name), startingSubstance.amount);
        }

        if (preRun)
        {
            using var csv = CSVManager.CreateFile("PreRunData");
            var headerItems = particles.Keys.Select(particle => particle.name).ToList();
            var sb = new System.Text.StringBuilder();

            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            for (var i = 0f; i < preRunFor; i += preRunInterval)
            {

                // create copy of particles dictionary to put changes in, since editing a dictionary that is currently being iterated over, throws an error
                var tempParticles = new Dictionary<RadioactiveSubstance, long>();

                // iterate over all items in the copy of the dictionary
                foreach (var (substance, amount) in particles)
                {
                    // initiate variables, calculate the decay product and writes it to particles
                    var decayed = Statistics.Decay(substance, amount, preRunInterval);
                    tempParticles.TryAdd(substance, 0);
                    foreach (var (particle, amount2) in decayed)
                    {
                        if (particle is GammaParticle or BetaParticle) continue;

                        tempParticles.TryAdd(particle, 0);
                        tempParticles[particle] += amount2;
                    }
                }

                foreach (var (particle, amount) in tempParticles)
                {
                    particles[particle] = amount;
                }

                var line = "";
                line += i + ",";

                var items = new string[particles.Count];

                foreach (var (substance, amount) in particles)
                {
                    var index = headerItems.FindIndex(particle => particle == substance.name);
                    if (index == -1)
                    {
                        headerItems.Add(substance.name);
                        index = headerItems.Count - 1;
                    }

                    items[index] = amount.ToString();
                }

                line = items.Aggregate(line, (current, item) => current + item + ",");

                sb.AppendLine(line);
            }

            stopwatch.Stop();
            Debug.Log("Pre run time: " + stopwatch.ElapsedMilliseconds + "ms");

            sb.Insert(0, "Time," + string.Join(",", headerItems) + "\n");


            csv.Write(sb.ToString());

            Debug.Log("Pre run finished");
            // print out particles and amounts
            foreach (var (particle, amount) in particles)
            {
                Debug.Log(particle.name + ": " + amount);
            }
        }

        if (onlyPreRun)
        {
            emitting = false;
            particles.Clear();
        }
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
    
    public static bool HasGammaAbsorbed(GammaParticle gammaParticle, double distance, double density, double massAttenuationCoefficient)
    {
        var attenuation = Math.Exp(-massAttenuationCoefficient * distance * (density / 1000));
        return UnityEngine.Random.value >= attenuation;
    }

    public static double maxEnergyFound = 0;
    
    public static bool HasBetaAbsorbed(BetaParticle betaParticle, double distance, double massStoppingPower, double density)
    {
        // mass thickness in g/cm^2
        var massThickness = density/1000 * distance;
        
        if (betaParticle.energy > maxEnergyFound)
        {
            maxEnergyFound = betaParticle.energy;
            Debug.Log("Max energy found: " + maxEnergyFound);
        }

        var energyLost = massStoppingPower * 1000000 * massThickness;
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
            case GammaParticle gammaParticle when HasGammaAbsorbed(gammaParticle, distance, material.material.density, material.material.GetMACForEnergy(gammaParticle.energy)):
            case BetaParticle electronParticle when HasBetaAbsorbed(electronParticle, distance, material.material.GetMSPForEnergy(electronParticle.energy), material.material.density):
                if (debugRender) Debug.DrawRay(transform.position, direction * distance, Color.red, 0.2f);
                return true;
        }

        return false;
    }

    private void SimulateParticle(RadioactiveSubstance particle, RadioactiveSubstance substance)
    {
        // give beta particles a random energy for absorption
        if (particle is BetaParticle betaParticle)
        {
            betaParticle.energy = Statistics.RandomBetaEnergy(betaParticle.spectrum);
            if (substance is Yttrium90) Debug.Log("Beta particle energy: " + betaParticle.energy);
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
        if (!emitting || onlyPreRun) return;
        
        double time = Time.deltaTime;

        // create copy of particles dictionary to put changes in, since editing a dictionary that is currently being iterated over, throws an error
        var tempParticles = new Dictionary<RadioactiveSubstance, long>();

        // iterate over all items in the copy of the dictionary
        foreach (var (substance, amount) in particles) {
            // initiate variables, calculate the decay product and writes it to particles
            var decayed = Statistics.Decay(substance, amount, time);
            tempParticles.TryAdd(substance, 0);
            foreach (var (particle, particleAmount) in decayed)
            {
                tempParticles.TryAdd(particle, 0);
                tempParticles[particle] += particleAmount;

                if (particle is not (GammaParticle or BetaParticle)) continue;

                for (var i = 0; i < particleAmount; i++)
                {
                    SimulateParticle(particle, substance);
                }
            }
        }
            
        foreach (var (particle, amount) in tempParticles)
        {
            particles[particle] = amount;
        }
        
        particles = particles.Where(pair => pair.Value > 0).ToDictionary(pair => pair.Key, pair => pair.Value);

    }
}

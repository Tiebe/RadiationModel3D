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
        if (emitting)
        {
            Emit();
        }
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

    private void FixedUpdate()
    {
        if (resetter)
        {
            particles.Clear();
            Emit();
            resetter = false;
            return;
        }
        
        if (!emitting)
        {
            return;
        }
        
        double time = Time.deltaTime;

        // create copy of particles dictionary to iterate over, since editing a dictionary that is currently being iterated over, throws an error
        var particlesCopy = particles.ToDictionary(entry => entry.Key, entry => entry.Value);
    
        // iterate over all items in the copy of the dictionary
        foreach (var entry in particlesCopy) {
            // initiate variables, calculate the decay product and writes it to particles
            var substance = entry.Key;
            var amount = entry.Value;
            var decayed = Statistics.Decay(substance, amount, time);
            particles[substance] = 0;
            foreach (var decay in decayed)
            {
                var particle = decay.Key;
                var particleAmount = decay.Value;

                if (particle is GammaParticle or BetaParticle)
                {
                    for (var i = 0; i < particleAmount; i++)
                    {
                        if (particle is BetaParticle betaParticle)
                        {
                            betaParticle.energy = Statistics.RandomBetaEnergy(betaParticle.spectrum);
                        }
                        
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
                            
                            continue;
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
                            
                            hitPoints.Add(new KeyValuePair<GameObject, Vector3[]>(entryHit.collider.gameObject, new Vector3[2] {entryHit.point, exitHit.point}));
                        }

                        var done = false;
                        var hasHitMaterial = false;
                        
                        foreach (var (hitGameObject, points) in hitPoints)
                        {
                            var entryPoint = points[0];
                            var exitPoint = points[1];
                            if (exitPoint.Equals(Vector3.zero))
                            {
                                Debug.Log("No exit point found. Is the collider configured correctly?");
                            }
                            var distance = Vector3.Distance(entryPoint, exitPoint);
                            
                            var material = RadiationModelMaterial.GetRadiationModelMaterial(hitGameObject);
                            if (material is not null)
                            {
                                hasHitMaterial = true;
                                if (particle is GammaParticle gammaParticle)
                                {
                                    var massAttenuationCoefficient = material.material.GetClosestMAC(gammaParticle.energy);
                                    
                                    var attenuation = Math.Exp(-massAttenuationCoefficient * distance);
                                    var absorbed = 1 - attenuation;
                                    if (UnityEngine.Random.value < absorbed)
                                    {
                                        if (debugRender)
                                        {
                                            Debug.DrawRay(transform.position, direction * distance, Color.red, 0.2f);
                                        }
                                        
                                        // kill this loop, which will cause it to continue in the parent loop
                                        done = true;
                                        break;
                                    }
                                }
                                else if (particle is BetaParticle electronParticle)
                                {
                                    var stoppingPower = material.material.GetClosestMSP(electronParticle.energy);
                                    // mass thickness in g/cm^2
                                    var massThickness = material.material.density * distance;
                                    
                                    var energyLost = stoppingPower * massThickness;
                                    electronParticle.energy -= energyLost;
                                    
                                    // if electron has lost all energy, remove it
                                    if (electronParticle.energy <= 0)
                                    {
                                        if (debugRender)
                                        {
                                            Debug.DrawRay(transform.position, direction * distance, Color.red, 0.2f);
                                        }
                                        
                                        // kill this loop, which will cause it to continue in the parent loop
                                        done = true;
                                        break;
                                    }
                                }
                            }

                            
                            if (RadiationReceiver.radiationReceivers.TryGetValue(hitGameObject, out var receiver))
                            {
                                receiver.RadiationHit(particle);
                            }
                            
                        }
                        
                        // do last hit
                        if (!done && RadiationReceiver.radiationReceivers.TryGetValue(lastHit.collider.gameObject, out var receiverLast))
                        {
                            receiverLast.RadiationHit(particle);
                            if (debugRender)
                            {
                                var distanceSinceStart = Vector3.Distance(origin, lastHit.point);
                                Debug.DrawRay(transform.position, direction * distanceSinceStart, Color.blue, 0.2f);
                            }
                        } else if (debugRender && !done && hasHitMaterial)
                        {
                            Debug.DrawRay(transform.position, direction * 50, Color.cyan, 0.2f);
                        } else if (debugRenderAll && !done)
                        {
                            Debug.DrawRay(transform.position, direction * 50, Color.green, 0.2f);
                        }
                    }
                }
                else
                {
                    var existing = 0L;
                    if (particles.TryGetValue(particle, out var amountParticles))
                    {
                        existing = amountParticles;
                    }

                    particles[particle] = existing + particleAmount;
                }
            }
        }

    }
}

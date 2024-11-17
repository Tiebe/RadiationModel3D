using System;
using System.Collections.Generic;
using System.Linq;
using RadiationModel;
using RadiationModel.statistics;
using RadiationModel.substances;
using UnityEngine;
using UnityEngine.Serialization;

public class RadiationEmitter : MonoBehaviour
{

    [FormerlySerializedAs("amount")] public int initalAmount;
    public string radioactiveSubstanceName;
    public bool emitting;
    public bool debugRender = false;

    private Dictionary<RadioactiveSubstance, long> particles = new();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        if (emitting)
        {
            Emit();
        }
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void Emit()
    {
        var substance = Substances.GetSubstanceByName(radioactiveSubstanceName);
        particles.Add(substance, initalAmount);
    }

    private void FixedUpdate()
    {
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
                        var origin = transform.position;
                        var direction = new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f));

                        //var direction = new Vector3(0, 0, 1);
                        var ray = new Ray(origin, direction);
                        // ReSharper disable once Unity.PreferNonAllocApi
                        var hits = Physics.RaycastAll(ray);
                        
                        List<KeyValuePair<GameObject, Vector3[]>> hitPoints = new();

                        foreach (var hit in hits)
                        {
                            var done = false;
                            foreach (var previousHitPair in hitPoints
                                         .Where(previousHitPair => previousHitPair.Key == hit.collider.gameObject)
                                         .Where(previousHitPair => previousHitPair.Value[1] == Vector3.zero))
                            {
                                previousHitPair.Value[1] = hit.point;
                                done = true;
                                break;
                            }
                            if (done) continue;
                            
                            hitPoints.Add(new KeyValuePair<GameObject, Vector3[]>(hit.collider.gameObject, new Vector3[2] {hit.point, Vector3.zero}));
                        } 
                        foreach (var (hitGameObject, points) in hitPoints)
                        {
                            var entryPoint = points[0];
                            var exitPoint = points[1];
                            var distance = Vector3.Distance(entryPoint, exitPoint);
                            
                            var material = RadiationModelMaterial.GetRadiationModelMaterial(hitGameObject);
                            if (material is not null)
                            {
                                if (particle is GammaParticle gammaParticle)
                                {
                                    var attenuation = Math.Exp(-material.MassAttenuationCoefficient * distance);
                                    var absorbed = 1 - attenuation;
                                    if (UnityEngine.Random.value < absorbed)
                                    {
                                        if (debugRender)
                                        {
                                            Debug.DrawRay(transform.position, direction, Color.red, 0.1f);
                                        }
                                        
                                        continue;
                                    }
                                }
                                else if (particle is BetaParticle electronParticle)
                                {
                                    // todo: implement electron attenuation
                                }
                            }
                            
                            // renders green lines for debugging
                            if (debugRender)
                            {
                                Debug.DrawRay(transform.position, direction, Color.green, 0.1f);
                            }

                            if (RadiationReceiver.radiationReceivers.TryGetValue(hitGameObject, out var receiver))
                            {
                                receiver.RadiationHit(particle);
                            }
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

using System;
using System.Collections.Generic;
using System.Linq;
using RadiationModel.statistics;
using RadiationModel.substances;
using UnityEngine;
using UnityEngine.Serialization;

public class RadiationEmitter : MonoBehaviour
{

    [FormerlySerializedAs("amount")] public int initalAmount;
    public string radioactiveSubstanceName;

    private Dictionary<RadioactiveSubstance, long> particles = new();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        var substance = Substances.GetSubstanceByName(radioactiveSubstanceName);
        particles.Add(substance, initalAmount);
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    int emmitted;
    private void FixedUpdate()
    {
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

                if (particle is GammaParticle or ElectronParticle)
                {
                    for (var i = 0; i < particleAmount; i++)
                    {
                        var direction = new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f));
                        //var direction = new Vector3(0, 0, 1);
                        if (!Physics.Raycast(transform.position, direction, out var hit)) continue;
                        if (RadiationReceiver.radiationReceivers.TryGetValue(hit.collider.gameObject, out var receiver))
                        {
                            receiver.RadiationHit(particle);
                        }
                        emmitted++;
                        // Debug.Log("emitted: " + emmitted);
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

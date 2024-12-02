using System.Linq;
using RadiationModel;
using UnityEngine;

public class GeigerTeller : RadiationReceiver
{
    public bool detectGamma;
    public bool detectBeta;

    private Manager manager;
    
    protected override void StartOverride()
    {
        if (manager == null)
        {
            manager = GameObject.FindGameObjectsWithTag("Manager").Select(go => go.GetComponent<Manager>()).First(m => m.enabled);
        }
    }
    

    public override void RadiationHit(RadioactiveSubstance particle)
    {
        switch (particle)
        {
            case GammaParticle when detectGamma:
            case BetaParticle when detectBeta:
                manager.OnHit(particle);
                break;
        }
    }
}
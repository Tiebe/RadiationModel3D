using System.Linq;
using RadiationModel;
using UnityEngine;

public class GeigerTeller : RadiationReceiver
{
    public bool detectGamma;
    public bool detectBeta;

    [HideInInspector]
    public Manager manager;
    
    protected override void StartOverride()
    {
        
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
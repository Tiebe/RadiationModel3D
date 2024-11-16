using RadiationModel;
using RadiationModel.substances;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GeigerTeller : RadiationReceiver
{
    public bool detectGamma;
    public bool detectBeta;

    private Manager manager;
    
    protected override void StartOverride()
    {
        if (manager == null)
        {
            manager = GameObject.FindWithTag("Manager").GetComponent<Manager>();
        }
    }

    public override void RadiationHit(RadioactiveSubstance particle)
    {
        if (particle is GammaParticle && detectGamma)
        {
            manager.hits++;
        }
        else if ((particle is BetaParticle) && detectBeta)
        {
            manager.hits++;
        }
    }
}
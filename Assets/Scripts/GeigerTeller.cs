using RadiationModel.substances;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GeigerTeller : RadiationReceiver
{
    private int hits = 0;

    public bool detectGamma;
    public bool detectBeta;
    
    private void Update()
    {
        
    }
    
    public override void RadiationHit(RadioactiveSubstance particle)
    {
        if ((particle is GammaParticle) && detectGamma)
        {
            hits++;
        }
        else if ((particle is ElectronParticle) && detectBeta)
        {
            hits++;
        }
        Debug.Log("Hit " + hits);
    }
}
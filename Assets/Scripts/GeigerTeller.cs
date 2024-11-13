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

    protected override void StartOverride()
    {
        var text = gameObject.GetComponent<TextMeshProUGUI>();
        text.text = "0";
    }
    
    public override void RadiationHit(RadioactiveSubstance particle)
    {
        if ((particle is GammaParticle) && detectGamma)
        {
            hits++;
        }
        else if ((particle is BetaParticle) && detectBeta)
        {
            hits++;
        }
        Debug.Log("Hit " + hits);
    }
}
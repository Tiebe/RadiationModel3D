using RadiationModel.substances;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GeigerTeller : RadiationReceiver
{
    private int hits = 0;

    public bool detectGamma;
    public bool detectBeta;

    private TextMeshProUGUI counter;
    
    protected override void StartOverride()
    {
        if (counter == null)
        {
            var go = GameObject.FindWithTag("Counter");
            counter = go.GetComponents<TextMeshProUGUI>()[0];
        }
    
        counter.text = "0";
    } 
    
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
        
        counter.text = hits.ToString();
    }
}
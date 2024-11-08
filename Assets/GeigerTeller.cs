using RadiationModel.substances;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GeigerTeller : RadiationReceiver
{
    private int hits = 0;
    private void Update()
    {
        
    }
    
    public override void RadiationHit(RadioactiveSubstance particle)
    {
        hits++;
        Debug.Log("Hit " + hits);
    }
}
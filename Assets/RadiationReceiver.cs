using System.Collections.Generic;
using RadiationModel.substances;
using UnityEngine;

public abstract class RadiationReceiver : MonoBehaviour
{
    public static readonly Dictionary<GameObject, RadiationReceiver> radiationReceivers = new();
    
    private void Start()
    {
        radiationReceivers.Add(gameObject, this);
    }

    public abstract void RadiationHit(RadioactiveSubstance particle);
}
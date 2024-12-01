using System.Collections.Generic;
using RadiationModel;
using UnityEngine;

public abstract class RadiationReceiver : MonoBehaviour
{
    public static readonly Dictionary<GameObject, RadiationReceiver> radiationReceivers = new();
    
    private void Start()
    {
        radiationReceivers.Add(gameObject, this);
        StartOverride();
    }

    protected abstract void StartOverride();

    public abstract void RadiationHit(RadioactiveSubstance particle);
}
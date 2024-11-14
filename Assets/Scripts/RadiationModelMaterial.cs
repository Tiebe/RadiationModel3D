using System.Collections.Generic;
using UnityEngine;

public class RadiationModelMaterial : MonoBehaviour
{
    private static readonly Dictionary<GameObject, RadiationModelMaterial> radiationModelMaterials = new();

    public double MassAttenuationCoefficient;
    
    
    public static RadiationModelMaterial GetRadiationModelMaterial(GameObject gameObject)
    {
        radiationModelMaterials.TryGetValue(gameObject, out var radiationModelMaterial);
        return radiationModelMaterial;
    }
    
    private void Start()
    {
        radiationModelMaterials.Add(gameObject, this);
    }
        
}
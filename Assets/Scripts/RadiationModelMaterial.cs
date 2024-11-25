using System.Collections.Generic;
using RadiationModel;
using UnityEngine;
using Material = RadiationModel.Material;

public class RadiationModelMaterial : MonoBehaviour
{
    private static readonly Dictionary<GameObject, RadiationModelMaterial> radiationModelMaterials = new();

    public double MassAttenuationCoefficient;
    public string materialString;

    [HideInInspector]
    public Material material;
    
    
    public static RadiationModelMaterial GetRadiationModelMaterial(GameObject gameObject)
    {
        radiationModelMaterials.TryGetValue(gameObject, out var radiationModelMaterial);
        return radiationModelMaterial;
    }
    
    private void Start()
    {
        material = Materials.GetMaterialByName(materialString);
        radiationModelMaterials.Add(gameObject, this);
    }
        
}
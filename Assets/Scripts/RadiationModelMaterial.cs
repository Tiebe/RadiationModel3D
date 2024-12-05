using System;
using System.Collections.Generic;
using RadiationModel;
using UnityEngine;
using Material = RadiationModel.Material;

public class RadiationModelMaterial : MonoBehaviour
{

    public string materialString;
    public bool warnings = false;

    [HideInInspector]
    public static Dictionary<GameObject, RadiationModelMaterial> radiationModelMaterials = new();
    public Material material;
    
    
    public static RadiationModelMaterial GetRadiationModelMaterial(GameObject gameObject)
    {
        radiationModelMaterials.TryGetValue(gameObject, out var radiationModelMaterial);
        return radiationModelMaterial;
    }

    public void ResetMaterial(string String = null)
    {
        radiationModelMaterials.Clear();
        if (String != null) materialString = String;
        material = Materials.GetMaterialByName(materialString);
        material.warnings = warnings;
        radiationModelMaterials.Add(gameObject, this);
    }

    private void Start()
    {
        ResetMaterial();
    }
        
}
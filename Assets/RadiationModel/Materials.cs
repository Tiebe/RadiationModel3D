

using System;
using System.Collections.Generic;
using RadiationModel.materials;

namespace RadiationModel
{
    public static class Materials
    {
        private static readonly Dictionary<string, Type> materials = new()
        {
            { "Lead", typeof(Lead) }
        };
        
        public static Material GetMaterialByName(string name)
        {
            return (Material) Activator.CreateInstance(materials[name]);
        }


    }
}
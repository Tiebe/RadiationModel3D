

using System;
using System.Collections.Generic;
using RadiationModel.materials;

namespace RadiationModel
{
    public static class Materials
    {
        public static readonly Dictionary<string, Type> materials = new()
        {
            { "Lead", typeof(Lead) },
            { "Aluminium", typeof(Aluminium) },
            { "Perspex", typeof(Perspex) },
        };
        
        public static Material GetMaterialByName(string name)
        {
            return (Material) Activator.CreateInstance(materials[name]);
        }


    }
}
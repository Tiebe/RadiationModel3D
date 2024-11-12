
using System;
using System.Collections.Generic;

namespace RadiationModel.substances
{
    // list of all radioactive substances names with their respective class
    public static class Substances
    {
        private static readonly Dictionary<string, Type> substances = new()
        {
            { "ElectronParticle", typeof(ElectronParticle) },
            { "GammaParticle", typeof(GammaParticle) }, 
            { "Protactinium234", typeof(Protactinium234) }, 
            { "Protactinium234m", typeof(Protactinium234m) }, 
            { "Technetium99", typeof(Technetium99) }, 
            { "Technetium99m", typeof(Technetium99m) }, 
            { "Uranium234", typeof(Uranium234) }, 
        };
        
        public static RadioactiveSubstance GetSubstanceByName(string name)
        {
            return (RadioactiveSubstance) Activator.CreateInstance(substances[name]);
        }
    }

}
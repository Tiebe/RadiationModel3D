using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium59 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium59";
        public override double halfLife { get; } = 0.0133d;
        public override double atomicWeight { get; } = 58.98243d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zinc57()), new(1.0d, new ProtonParticle()) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
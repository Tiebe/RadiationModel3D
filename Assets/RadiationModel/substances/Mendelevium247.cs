using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium247";
        public override double halfLife { get; } = 1.2d;
        public override double atomicWeight { get; } = 247.08152d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9990000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium243()), new(1.0d, new AlphaParticle(9787002.09)) } },
            { 0.001d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead185 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead185";
        public override double halfLife { get; } = 6.3d;
        public override double atomicWeight { get; } = 184.98761d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.34d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury181()), new(1.0d, new AlphaParticle(7717002.09)) } },
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
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium123";
        public override double halfLife { get; } = 0.0422d;
        public override double atomicWeight { get; } = 122.94719d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium123()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.242d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium123()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
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
    
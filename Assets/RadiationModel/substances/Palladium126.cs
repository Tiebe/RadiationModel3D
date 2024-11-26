using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium126 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium126";
        public override double halfLife { get; } = 0.0485d;
        public override double atomicWeight { get; } = 125.9444d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver126()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.049d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver126()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
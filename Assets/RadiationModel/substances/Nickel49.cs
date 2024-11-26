using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel49 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel49";
        public override double halfLife { get; } = 0.0075d;
        public override double atomicWeight { get; } = 49.00916d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iron49()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.83d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iron48()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()), new(0.82d, new GammaParticle(969500.0, 0.00128)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
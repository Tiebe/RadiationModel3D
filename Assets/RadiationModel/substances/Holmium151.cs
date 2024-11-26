using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium151";
        public override double halfLife { get; } = 35.2d;
        public override double atomicWeight { get; } = 150.9317d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.78d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium151()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.22d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium147()), new(1.0d, new AlphaParticle(5717002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
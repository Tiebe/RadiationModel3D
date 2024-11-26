using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium95";
        public override double halfLife { get; } = 0.032d;
        public override double atomicWeight { get; } = 94.94948d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver95()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.045d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium94()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur45 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur45";
        public override double halfLife { get; } = 0.068d;
        public override double atomicWeight { get; } = 44.99641d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chlorine45()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.54d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chlorine45()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
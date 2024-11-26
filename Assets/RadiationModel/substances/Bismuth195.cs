using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth195 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth195";
        public override double halfLife { get; } = 183.0d;
        public override double atomicWeight { get; } = 194.98065d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9997d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium195()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0003d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium191()), new(1.0d, new AlphaParticle(6854002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
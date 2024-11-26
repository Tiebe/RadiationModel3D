using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury197 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury197";
        public override double halfLife { get; } = 230904.0d;
        public override double atomicWeight { get; } = 196.96721d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold197()), new(0.187d, new GammaParticle(77351.0, 0.01603)), new(0.006320599999999999d, new GammaParticle(191364.0, 0.00648)), new(0.0003927d, new GammaParticle(268710.0, 0.00461)), new(0.48d, new GammaParticle(11419.0, 0.10858)), new(0.215d, new GammaParticle(66991.0, 0.01851)), new(0.366d, new GammaParticle(68806.0, 0.01802)), new(0.1234d, new GammaParticle(78048.0, 0.01589)), new(0.159d, new GammaParticle(78983.0, 0.0157)), new(0.035699999999999996d, new GammaParticle(80133.0, 0.01547)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
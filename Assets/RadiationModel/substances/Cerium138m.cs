using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium138m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium138m";
        public override double halfLife { get; } = 0.00873d;
        public override double atomicWeight { get; } = 137.90828d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cerium138()), new(0.845d, new GammaParticle(302900.0, 0.00409)), new(0.9965999999999999d, new GammaParticle(789200.0, 0.00157)), new(0.9981d, new GammaParticle(1037600.0, 0.00119)), new(0.016875924d, new GammaParticle(5410.0, 0.22918)), new(0.02812518700799579d, new GammaParticle(34279.0, 0.03617)), new(0.05151133151647581d, new GammaParticle(34720.0, 0.03571)), new(0.015514514733276245d, new GammaParticle(39366.0, 0.0315)), new(0.019455201475528414d, new GammaParticle(39753.0, 0.03119)), new(0.0039406867422521665d, new GammaParticle(40229.0, 0.03082)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
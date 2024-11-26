using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton83n : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton83n";
        public override double halfLife { get; } = 6588.0d;
        public override double atomicWeight { get; } = 82.91417d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Krypton83()), new(0.055d, new GammaParticle(9405.7, 0.13182)), new(0.000616d, new GammaParticle(32151.6, 0.03856)), new(0.037021967999999995d, new GammaParticle(1648.0, 0.75233)), new(0.047046929959670455d, new GammaParticle(12596.0, 0.09843)), new(0.0907191090622261d, new GammaParticle(12649.0, 0.09802)), new(0.021738700016445702d, new GammaParticle(14169.0, 0.0875)), new(0.02392996097810343d, new GammaParticle(14209.0, 0.08726)), new(0.0021912609616577265d, new GammaParticle(14313.0, 0.08662)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
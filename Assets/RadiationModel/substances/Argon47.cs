using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon47 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon47";
        public override double halfLife { get; } = 1.23d;
        public override double atomicWeight { get; } = 46.97277d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium47() }, { 1.0d, new BetaParticle(-1, 5172350.0) }, { 0.7d, new GammaParticle(360000.0, 0.00344) }, { 0.371d, new GammaParticle(1660000.0, 0.00075) }, { 0.287d, new GammaParticle(1742000.0, 0.00071) }, { 0.049d, new GammaParticle(2020000.0, 0.00061) }, { 0.021d, new GammaParticle(3207000.0, 0.00039) }, { 0.006999999999999999d, new GammaParticle(3316000.0, 0.00037) }, { 0.006999999999999999d, new GammaParticle(3357000.0, 0.00037) }, { 0.027999999999999997d, new GammaParticle(3402000.0, 0.00036) }, { 0.098d, new GammaParticle(3718000.0, 0.00033) }, { 0.042d, new GammaParticle(3822000.0, 0.00032) }, { 0.021d, new GammaParticle(4010000.0, 0.00031) }, { 2.2568476751660002e-06d, new GammaParticle(311.0, 3.98663) }, { 3.0584382277809875e-05d, new GammaParticle(3311.0, 0.37446) }, { 6.0503229036221304e-05d, new GammaParticle(3314.0, 0.37412) }, { 1.1158232385968818e-05d, new GammaParticle(3591.0, 0.34526) }, { 1.1158232385968818e-05d, new GammaParticle(3591.0, 0.34526) } } },
            { 0.002d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium47() }, { 1.0d, new BetaParticle(-1, 5172350.0) }, { 0.7d, new GammaParticle(360000.0, 0.00344) }, { 0.371d, new GammaParticle(1660000.0, 0.00075) }, { 0.287d, new GammaParticle(1742000.0, 0.00071) }, { 0.049d, new GammaParticle(2020000.0, 0.00061) }, { 0.021d, new GammaParticle(3207000.0, 0.00039) }, { 0.006999999999999999d, new GammaParticle(3316000.0, 0.00037) }, { 0.006999999999999999d, new GammaParticle(3357000.0, 0.00037) }, { 0.027999999999999997d, new GammaParticle(3402000.0, 0.00036) }, { 0.098d, new GammaParticle(3718000.0, 0.00033) }, { 0.042d, new GammaParticle(3822000.0, 0.00032) }, { 0.021d, new GammaParticle(4010000.0, 0.00031) }, { 2.2568476751660002e-06d, new GammaParticle(311.0, 3.98663) }, { 3.0584382277809875e-05d, new GammaParticle(3311.0, 0.37446) }, { 6.0503229036221304e-05d, new GammaParticle(3314.0, 0.37412) }, { 1.1158232385968818e-05d, new GammaParticle(3591.0, 0.34526) }, { 1.1158232385968818e-05d, new GammaParticle(3591.0, 0.34526) } } },

        };
    }
}
    
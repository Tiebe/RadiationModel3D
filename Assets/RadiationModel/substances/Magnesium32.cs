using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium32 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium32";
        public override double halfLife { get; } = 0.086d;
        public override double atomicWeight { get; } = 31.99911d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum32() }, { 1.0d, new BetaParticle(-1, 5135000.0) }, { 0.021d, new GammaParticle(222000.0, 0.00558) }, { 0.021d, new GammaParticle(222000.0, 0.00558) }, { 0.006d, new GammaParticle(565000.0, 0.00219) }, { 0.09d, new GammaParticle(735500.0, 0.00169) }, { 0.009000000000000001d, new GammaParticle(787000.0, 0.00158) }, { 0.027999999999999997d, new GammaParticle(1743000.0, 0.00071) }, { 0.013999999999999999d, new GammaParticle(2030000.0, 0.00061) }, { 0.07200000000000001d, new GammaParticle(2466900.0, 0.0005) }, { 0.23199999999999998d, new GammaParticle(2765300.0, 0.00045) }, { 0.035d, new GammaParticle(3202000.0, 0.00039) } } },
            { 0.055d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum32() }, { 1.0d, new BetaParticle(-1, 5135000.0) }, { 0.021d, new GammaParticle(222000.0, 0.00558) }, { 0.021d, new GammaParticle(222000.0, 0.00558) }, { 0.006d, new GammaParticle(565000.0, 0.00219) }, { 0.09d, new GammaParticle(735500.0, 0.00169) }, { 0.009000000000000001d, new GammaParticle(787000.0, 0.00158) }, { 0.027999999999999997d, new GammaParticle(1743000.0, 0.00071) }, { 0.013999999999999999d, new GammaParticle(2030000.0, 0.00061) }, { 0.07200000000000001d, new GammaParticle(2466900.0, 0.0005) }, { 0.23199999999999998d, new GammaParticle(2765300.0, 0.00045) }, { 0.035d, new GammaParticle(3202000.0, 0.00039) } } },

        };
    }
}
    
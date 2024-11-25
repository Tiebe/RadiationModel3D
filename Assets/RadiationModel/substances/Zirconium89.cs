using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium89";
        public override double halfLife { get; } = 282276.0d;
        public override double atomicWeight { get; } = 88.90888d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium89() }, { 1.0d, new BetaParticle(1, 665515.0) }, { 0.9904000000000001d, new GammaParticle(909150.0, 0.00136) }, { 0.0007328959999999999d, new GammaParticle(1620800.0, 0.00076) }, { 0.001059728d, new GammaParticle(1657300.0, 0.00075) }, { 0.007447808d, new GammaParticle(1713000.0, 0.00072) }, { 0.0012280960000000001d, new GammaParticle(1744500.0, 0.00071) }, { 0.4548d, new GammaParticle(511000.0, 0.00243) }, { 0.023650008021806855d, new GammaParticle(2027.0, 0.61166) }, { 0.14088707695846853d, new GammaParticle(14883.0, 0.08331) }, { 0.27015738630578817d, new GammaParticle(14958.0, 0.08289) }, { 0.06783317240863568d, new GammaParticle(16803.0, 0.07379) }, { 0.0771941502010274d, new GammaParticle(16880.0, 0.07345) }, { 0.009360977792391725d, new GammaParticle(17011.0, 0.07288) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium89";
        public override double halfLife { get; } = 4368643.2d;
        public override double atomicWeight { get; } = 88.90745d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium89() }, { 1.0d, new BetaParticle(-1, 751085.0) }, { 9.56e-05d, new GammaParticle(908960.0, 0.00136) }, { 2.46937942372e-08d, new GammaParticle(2027.0, 0.61166) }, { 1.467569790913503e-07d, new GammaParticle(14883.0, 0.08331) }, { 2.8141319097094975e-07d, new GammaParticle(14958.0, 0.08289) }, { 7.065936549885762e-08d, new GammaParticle(16803.0, 0.07379) }, { 8.041035793769996e-08d, new GammaParticle(16880.0, 0.07345) }, { 9.750992438842352e-09d, new GammaParticle(17011.0, 0.07288) } } },

        };
    }
}
    
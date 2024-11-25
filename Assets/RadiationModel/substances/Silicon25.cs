using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon25 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon25";
        public override double halfLife { get; } = 0.22d;
        public override double atomicWeight { get; } = 25.00411d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium25() }, { 1.0d, new BetaParticle(1, 8509890.0) }, { 2.0096000000000003d, new GammaParticle(511000.0, 0.00243) }, { 8.55274385952e-08d, new GammaParticle(91.0, 13.62464) }, { 2.668569781153353e-06d, new GammaParticle(1487.0, 0.83379) }, { 1.3430911708544827e-06d, new GammaParticle(1487.0, 0.83379) }, { 8.424487999216455e-08d, new GammaParticle(1558.0, 0.79579) }, { 8.424487999216455e-08d, new GammaParticle(1558.0, 0.79579) } } },
            { 0.35d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium24() }, { 1.0d, new BetaParticle(1, 474627340.736) }, { 1.0d, new ProtonParticle() }, { 0.221d, new GammaParticle(1368625.0, 0.00091) }, { 0.009399999999999999d, new GammaParticle(2754016.0, 0.00045) }, { 0.00147d, new GammaParticle(2869500.0, 0.00043) }, { 0.0044d, new GammaParticle(4237960.0, 0.00029) } } },

        };
    }
}
    
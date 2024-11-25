using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium96";
        public override double halfLife { get; } = 1.07d;
        public override double atomicWeight { get; } = 95.92172d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium96() }, { 1.0d, new BetaParticle(-1, 2706000.0) }, { 0.765d, new GammaParticle(122297.0, 0.01014) }, { 0.0076500000000000005d, new GammaParticle(213000.0, 0.00582) }, { 0.08262d, new GammaParticle(279400.0, 0.00444) }, { 0.0053549999999999995d, new GammaParticle(356000.0, 0.00348) }, { 0.089505d, new GammaParticle(530000.0, 0.00234) }, { 0.00918d, new GammaParticle(596400.0, 0.00208) }, { 0.00459d, new GammaParticle(652300.0, 0.0019) }, { 0.0034425d, new GammaParticle(695400.0, 0.00178) }, { 0.7191d, new GammaParticle(809400.0, 0.00153) }, { 0.11781000000000001d, new GammaParticle(931700.0, 0.00133) }, { 0.0038250000000000003d, new GammaParticle(1052600.0, 0.00118) }, { 0.000765d, new GammaParticle(1166000.0, 0.00106) }, { 0.00612d, new GammaParticle(1331600.0, 0.00093) }, { 0.00153d, new GammaParticle(1861300.0, 0.00067) }, { 0.019125d, new GammaParticle(1983500.0, 0.00063) }, { 0.002460238336896732d, new GammaParticle(2027.0, 0.61166) }, { 0.014709097396598751d, new GammaParticle(14883.0, 0.08331) }, { 0.02820536413537632d, new GammaParticle(14958.0, 0.08289) }, { 0.007082017465470054d, new GammaParticle(16803.0, 0.07379) }, { 0.00805933587570492d, new GammaParticle(16880.0, 0.07345) }, { 0.0009773184102348674d, new GammaParticle(17011.0, 0.07288) } } },

        };
    }
}
    
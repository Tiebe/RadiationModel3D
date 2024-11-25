using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine93 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine93";
        public override double halfLife { get; } = 0.102d;
        public override double atomicWeight { get; } = 92.94322d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton93() }, { 1.0d, new BetaParticle(-1, 5623000.0) }, { 0.19d, new GammaParticle(117400.0, 0.01056) }, { 0.05624d, new GammaParticle(237400.0, 0.00522) }, { 0.114d, new GammaParticle(242000.0, 0.00512) }, { 0.006840000000000001d, new GammaParticle(349900.0, 0.00354) }, { 0.00703d, new GammaParticle(359400.0, 0.00345) }, { 0.012920000000000001d, new GammaParticle(446000.0, 0.00278) }, { 0.020139999999999998d, new GammaParticle(592700.0, 0.00209) }, { 0.0019d, new GammaParticle(629000.0, 0.00197) }, { 0.0064600000000000005d, new GammaParticle(669500.0, 0.00185) }, { 0.010069999999999999d, new GammaParticle(687900.0, 0.0018) }, { 0.03743d, new GammaParticle(710200.0, 0.00175) }, { 0.011399999999999999d, new GammaParticle(966400.0, 0.00128) }, { 0.013300000000000001d, new GammaParticle(977600.0, 0.00127) }, { 0.0019d, new GammaParticle(1142000.0, 0.00109) }, { 0.0019d, new GammaParticle(1220000.0, 0.00102) }, { 0.0361d, new GammaParticle(2103500.0, 0.00059) }, { 0.00817d, new GammaParticle(2224700.0, 0.00056) }, { 0.00266d, new GammaParticle(3085800.0, 0.0004) }, { 0.01482d, new GammaParticle(3606300.0, 0.00034) }, { 0.00042311929996000005d, new GammaParticle(1648.0, 0.75233) }, { 0.0029074547422205765d, new GammaParticle(12596.0, 0.09843) }, { 0.005606353147359384d, new GammaParticle(12649.0, 0.09802) }, { 0.001343430623564716d, new GammaParticle(14169.0, 0.0875) }, { 0.001478848430420039d, new GammaParticle(14209.0, 0.08726) }, { 0.00013541780685532337d, new GammaParticle(14313.0, 0.08662) } } },
            { 0.68d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton93() }, { 1.0d, new BetaParticle(-1, 5623000.0) }, { 0.19d, new GammaParticle(117400.0, 0.01056) }, { 0.05624d, new GammaParticle(237400.0, 0.00522) }, { 0.114d, new GammaParticle(242000.0, 0.00512) }, { 0.006840000000000001d, new GammaParticle(349900.0, 0.00354) }, { 0.00703d, new GammaParticle(359400.0, 0.00345) }, { 0.012920000000000001d, new GammaParticle(446000.0, 0.00278) }, { 0.020139999999999998d, new GammaParticle(592700.0, 0.00209) }, { 0.0019d, new GammaParticle(629000.0, 0.00197) }, { 0.0064600000000000005d, new GammaParticle(669500.0, 0.00185) }, { 0.010069999999999999d, new GammaParticle(687900.0, 0.0018) }, { 0.03743d, new GammaParticle(710200.0, 0.00175) }, { 0.011399999999999999d, new GammaParticle(966400.0, 0.00128) }, { 0.013300000000000001d, new GammaParticle(977600.0, 0.00127) }, { 0.0019d, new GammaParticle(1142000.0, 0.00109) }, { 0.0019d, new GammaParticle(1220000.0, 0.00102) }, { 0.0361d, new GammaParticle(2103500.0, 0.00059) }, { 0.00817d, new GammaParticle(2224700.0, 0.00056) }, { 0.00266d, new GammaParticle(3085800.0, 0.0004) }, { 0.01482d, new GammaParticle(3606300.0, 0.00034) }, { 0.00042311929996000005d, new GammaParticle(1648.0, 0.75233) }, { 0.0029074547422205765d, new GammaParticle(12596.0, 0.09843) }, { 0.005606353147359384d, new GammaParticle(12649.0, 0.09802) }, { 0.001343430623564716d, new GammaParticle(14169.0, 0.0875) }, { 0.001478848430420039d, new GammaParticle(14209.0, 0.08726) }, { 0.00013541780685532337d, new GammaParticle(14313.0, 0.08662) } } },

        };
    }
}
    
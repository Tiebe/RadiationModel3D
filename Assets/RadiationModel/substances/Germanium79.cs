using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium79 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium79";
        public override double halfLife { get; } = 18.98d;
        public override double atomicWeight { get; } = 78.92536d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic79() }, { 1.0d, new BetaParticle(-1, 2053000.0) }, { 0.026964000000000002d, new GammaParticle(100480.0, 0.01234) }, { 0.214d, new GammaParticle(109580.0, 0.01131) }, { 0.016906d, new GammaParticle(230620.0, 0.00538) }, { 0.0013054d, new GammaParticle(287800.0, 0.00431) }, { 0.0011342000000000001d, new GammaParticle(306980.0, 0.00404) }, { 0.002461d, new GammaParticle(325500.0, 0.00381) }, { 0.021614d, new GammaParticle(503260.0, 0.00246) }, { 0.0008346d, new GammaParticle(524450.0, 0.00236) }, { 0.0012412d, new GammaParticle(551210.0, 0.00225) }, { 0.010914d, new GammaParticle(603700.0, 0.00205) }, { 0.0026108d, new GammaParticle(634000.0, 0.00196) }, { 0.004708d, new GammaParticle(724130.0, 0.00171) }, { 0.00428d, new GammaParticle(749100.0, 0.00166) }, { 0.0029104d, new GammaParticle(774740.0, 0.0016) }, { 0.0034668d, new GammaParticle(808220.0, 0.00153) }, { 0.0037022d, new GammaParticle(825030.0, 0.0015) }, { 0.0034668d, new GammaParticle(871780.0, 0.00142) }, { 0.0025038d, new GammaParticle(1031590.0, 0.0012) }, { 0.009416d, new GammaParticle(1181440.0, 0.00105) }, { 0.003317d, new GammaParticle(1259650.0, 0.00098) }, { 0.0025679999999999995d, new GammaParticle(1265800.0, 0.00098) }, { 0.0041088d, new GammaParticle(1275260.0, 0.00097) }, { 0.020972d, new GammaParticle(1396530.0, 0.00089) }, { 0.005564d, new GammaParticle(1418020.0, 0.00087) }, { 0.09202d, new GammaParticle(1505850.0, 0.00082) }, { 0.0024396d, new GammaParticle(1538440.0, 0.00081) }, { 0.0030388d, new GammaParticle(1557260.0, 0.0008) }, { 0.0032528d, new GammaParticle(1571330.0, 0.00079) }, { 0.0021828d, new GammaParticle(1845370.0, 0.00067) }, { 0.006634d, new GammaParticle(1869250.0, 0.00066) }, { 0.0026108d, new GammaParticle(2594200.0, 0.00048) }, { 0.0005593985882872d, new GammaParticle(1320.0, 0.93927) }, { 0.004504639044049387d, new GammaParticle(10509.0, 0.11798) }, { 0.00874177963137859d, new GammaParticle(10544.0, 0.11759) }, { 0.0019988332670765286d, new GammaParticle(11773.0, 0.10531) }, { 0.002074389164572021d, new GammaParticle(11791.0, 0.10515) }, { 7.555589749549278e-05d, new GammaParticle(11861.0, 0.10453) } } },

        };
    }
}
    
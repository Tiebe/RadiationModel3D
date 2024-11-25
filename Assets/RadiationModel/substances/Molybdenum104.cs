using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum104 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum104";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 103.91375d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium104() }, { 1.0d, new BetaParticle(-1, 1077500.0) }, { 0.14d, new GammaParticle(36300.0, 0.03416) }, { 0.08d, new GammaParticle(46000.0, 0.02695) }, { 0.039d, new GammaParticle(50000.0, 0.0248) }, { 0.086d, new GammaParticle(55000.0, 0.02254) }, { 0.55d, new GammaParticle(68800.0, 0.01802) }, { 0.17800000000000002d, new GammaParticle(69700.0, 0.01779) }, { 0.02d, new GammaParticle(86000.0, 0.01442) }, { 0.03d, new GammaParticle(87000.0, 0.01425) }, { 0.049d, new GammaParticle(91000.0, 0.01362) }, { 0.0009d, new GammaParticle(92000.0, 0.01348) }, { 0.001d, new GammaParticle(98000.0, 0.01265) }, { 0.0026d, new GammaParticle(101000.0, 0.01228) }, { 0.0088d, new GammaParticle(105200.0, 0.01179) }, { 0.0007000000000000001d, new GammaParticle(114600.0, 0.01082) }, { 0.01d, new GammaParticle(115000.0, 0.01078) }, { 0.0006d, new GammaParticle(132000.0, 0.00939) }, { 0.0073d, new GammaParticle(151000.0, 0.00821) }, { 0.0044d, new GammaParticle(159500.0, 0.00777) }, { 0.0037d, new GammaParticle(178300.0, 0.00695) }, { 0.0075d, new GammaParticle(189300.0, 0.00655) }, { 0.0037d, new GammaParticle(196100.0, 0.00632) }, { 0.0022d, new GammaParticle(199100.0, 0.00623) }, { 0.003d, new GammaParticle(221700.0, 0.00559) }, { 0.006d, new GammaParticle(335000.0, 0.0037) }, { 0.047d, new GammaParticle(376000.0, 0.0033) }, { 0.013000000000000001d, new GammaParticle(393100.0, 0.00315) }, { 0.026000000000000002d, new GammaParticle(421000.0, 0.00294) }, { 0.0028000000000000004d, new GammaParticle(444800.0, 0.00279) }, { 0.006999999999999999d, new GammaParticle(467200.0, 0.00265) }, { 0.001d, new GammaParticle(535000.0, 0.00232) }, { 0.0039000000000000003d, new GammaParticle(604100.0, 0.00205) }, { 0.003d, new GammaParticle(659000.0, 0.00188) }, { 0.0033d, new GammaParticle(710400.0, 0.00175) }, { 0.006999999999999999d, new GammaParticle(733700.0, 0.00169) }, { 0.006999999999999999d, new GammaParticle(768600.0, 0.00161) }, { 0.006999999999999999d, new GammaParticle(796700.0, 0.00156) }, { 0.09852576692239999d, new GammaParticle(2586.0, 0.47944) }, { 0.44952388204981014d, new GammaParticle(18250.0, 0.06794) }, { 0.8547706447039554d, new GammaParticle(18367.0, 0.0675) }, { 0.2271815250831041d, new GammaParticle(20695.0, 0.05991) }, { 0.2630762060462345d, new GammaParticle(20820.0, 0.05955) }, { 0.03589468096313045d, new GammaParticle(21003.0, 0.05903) } } },

        };
    }
}
    
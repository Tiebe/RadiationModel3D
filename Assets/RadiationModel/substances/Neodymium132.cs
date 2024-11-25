using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium132";
        public override double halfLife { get; } = 94.0d;
        public override double atomicWeight { get; } = 131.92332d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium132() }, { 1.0d, new BetaParticle(1, 5521500.0) }, { 0.009408d, new GammaParticle(99100.0, 0.01251) }, { 0.004704d, new GammaParticle(102400.0, 0.01211) }, { 0.007056d, new GammaParticle(117900.0, 0.01052) }, { 0.07937999999999999d, new GammaParticle(136900.0, 0.00906) }, { 0.066444d, new GammaParticle(140600.0, 0.00882) }, { 0.588d, new GammaParticle(147700.0, 0.00839) }, { 0.048804d, new GammaParticle(195200.0, 0.00635) }, { 0.005292d, new GammaParticle(199100.0, 0.00623) }, { 0.024696d, new GammaParticle(213300.0, 0.00581) }, { 0.007644d, new GammaParticle(224600.0, 0.00552) }, { 0.007644d, new GammaParticle(237800.0, 0.00521) }, { 0.015288d, new GammaParticle(239600.0, 0.00517) }, { 0.003528d, new GammaParticle(257400.0, 0.00482) }, { 0.051744000000000005d, new GammaParticle(284500.0, 0.00436) }, { 0.036456d, new GammaParticle(288200.0, 0.0043) }, { 0.010584d, new GammaParticle(299000.0, 0.00415) }, { 0.007056d, new GammaParticle(342800.0, 0.00362) }, { 0.024696d, new GammaParticle(352800.0, 0.00351) }, { 0.004116d, new GammaParticle(372000.0, 0.00333) }, { 0.0294d, new GammaParticle(378600.0, 0.00327) }, { 0.011172d, new GammaParticle(382200.0, 0.00324) }, { 0.009996d, new GammaParticle(414200.0, 0.00299) }, { 0.019403999999999998d, new GammaParticle(419700.0, 0.00295) }, { 0.015288d, new GammaParticle(426800.0, 0.0029) }, { 0.07761599999999999d, new GammaParticle(430400.0, 0.00288) }, { 0.013524000000000001d, new GammaParticle(440000.0, 0.00282) }, { 0.016464d, new GammaParticle(482700.0, 0.00257) }, { 0.008232d, new GammaParticle(501400.0, 0.00247) }, { 0.12759600000000001d, new GammaParticle(567000.0, 0.00219) }, { 0.016464d, new GammaParticle(576800.0, 0.00215) }, { 0.011172d, new GammaParticle(693700.0, 0.00179) }, { 0.007644d, new GammaParticle(707200.0, 0.00175) }, { 0.015288d, new GammaParticle(725200.0, 0.00171) }, { 0.015875999999999998d, new GammaParticle(834200.0, 0.00149) }, { 0.035868000000000004d, new GammaParticle(981300.0, 0.00126) }, { 0.014112d, new GammaParticle(1041700.0, 0.00119) }, { 0.019992d, new GammaParticle(1045700.0, 0.00119) }, { 0.01176d, new GammaParticle(1182500.0, 0.00105) }, { 0.012936000000000001d, new GammaParticle(1293000.0, 0.00096) }, { 0.9216d, new GammaParticle(511000.0, 0.00243) }, { 0.102d, new GammaParticle(5637.0, 0.21995) }, { 0.196d, new GammaParticle(35551.0, 0.03488) }, { 0.35700000000000004d, new GammaParticle(36027.0, 0.03441) }, { 0.109d, new GammaParticle(40857.0, 0.03035) }, { 0.136d, new GammaParticle(41266.0, 0.03005) }, { 0.0278d, new GammaParticle(41766.0, 0.02969) } } },

        };
    }
}
    
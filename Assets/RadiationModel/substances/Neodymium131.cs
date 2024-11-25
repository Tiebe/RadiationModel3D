using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium131";
        public override double halfLife { get; } = 25.4d;
        public override double atomicWeight { get; } = 130.92725d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium131() }, { 1.0d, new BetaParticle(1, 5971000.0) }, { 0.3042d, new GammaParticle(87600.0, 0.01415) }, { 0.16899999999999998d, new GammaParticle(164200.0, 0.00755) }, { 0.12844d, new GammaParticle(174500.0, 0.00711) }, { 0.004225d, new GammaParticle(188400.0, 0.00658) }, { 0.04394d, new GammaParticle(196700.0, 0.0063) }, { 0.010985d, new GammaParticle(198500.0, 0.00625) }, { 0.00845d, new GammaParticle(220500.0, 0.00562) }, { 0.02366d, new GammaParticle(251600.0, 0.00493) }, { 0.007605d, new GammaParticle(253800.0, 0.00489) }, { 0.04056d, new GammaParticle(261900.0, 0.00473) }, { 0.03549d, new GammaParticle(305200.0, 0.00406) }, { 0.00845d, new GammaParticle(310000.0, 0.004) }, { 0.03718d, new GammaParticle(360800.0, 0.00344) }, { 0.07774d, new GammaParticle(362600.0, 0.00342) }, { 0.006253d, new GammaParticle(406800.0, 0.00305) }, { 0.01352d, new GammaParticle(417100.0, 0.00297) }, { 0.0030420000000000004d, new GammaParticle(419500.0, 0.00296) }, { 0.01183d, new GammaParticle(427900.0, 0.0029) }, { 0.01859d, new GammaParticle(428200.0, 0.0029) }, { 0.01352d, new GammaParticle(450000.0, 0.00276) }, { 0.10816d, new GammaParticle(460500.0, 0.00269) }, { 0.007098d, new GammaParticle(462100.0, 0.00268) }, { 0.041405000000000004d, new GammaParticle(469400.0, 0.00264) }, { 0.028730000000000002d, new GammaParticle(484400.0, 0.00256) }, { 0.01859d, new GammaParticle(515600.0, 0.0024) }, { 0.002535d, new GammaParticle(525400.0, 0.00236) }, { 0.002535d, new GammaParticle(525400.0, 0.00236) }, { 0.004225d, new GammaParticle(526700.0, 0.00235) }, { 0.00507d, new GammaParticle(535900.0, 0.00231) }, { 0.02366d, new GammaParticle(547300.0, 0.00227) }, { 0.01183d, new GammaParticle(576800.0, 0.00215) }, { 0.00845d, new GammaParticle(581100.0, 0.00213) }, { 0.01183d, new GammaParticle(593300.0, 0.00209) }, { 0.00338d, new GammaParticle(627500.0, 0.00198) }, { 0.00676d, new GammaParticle(636500.0, 0.00195) }, { 0.09126d, new GammaParticle(641500.0, 0.00193) }, { 0.14196d, new GammaParticle(668000.0, 0.00186) }, { 0.01014d, new GammaParticle(680900.0, 0.00182) }, { 0.00676d, new GammaParticle(685000.0, 0.00181) }, { 0.02028d, new GammaParticle(700000.0, 0.00177) }, { 0.00338d, new GammaParticle(724000.0, 0.00171) }, { 0.01859d, new GammaParticle(724100.0, 0.00171) }, { 0.0169d, new GammaParticle(741100.0, 0.00167) }, { 0.01521d, new GammaParticle(804900.0, 0.00154) }, { 0.00676d, new GammaParticle(824300.0, 0.0015) }, { 0.01352d, new GammaParticle(835800.0, 0.00148) }, { 0.01859d, new GammaParticle(923900.0, 0.00134) }, { 0.08112d, new GammaParticle(1118000.0, 0.00111) }, { 0.007605d, new GammaParticle(1152000.0, 0.00108) }, { 0.10816d, new GammaParticle(1183400.0, 0.00105) }, { 0.008957d, new GammaParticle(1240000.0, 0.001) }, { 1.8768d, new GammaParticle(511000.0, 0.00243) }, { 0.0898346283384d, new GammaParticle(5637.0, 0.21995) }, { 0.17051541822275978d, new GammaParticle(35551.0, 0.03488) }, { 0.3113868119480639d, new GammaParticle(36027.0, 0.03441) }, { 0.09473062152004488d, new GammaParticle(40857.0, 0.03035) }, { 0.11898166062917637d, new GammaParticle(41266.0, 0.03005) }, { 0.02425103910913149d, new GammaParticle(41766.0, 0.02969) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium130() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
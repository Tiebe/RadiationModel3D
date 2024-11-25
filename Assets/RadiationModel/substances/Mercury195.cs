using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury195 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury195";
        public override double halfLife { get; } = 37908.0d;
        public override double atomicWeight { get; } = 194.96671d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum195() }, { 1.0d, new BetaParticle(1, 890450.0) }, { 6.37e-06d, new GammaParticle(56800.0, 0.02183) }, { 0.0637d, new GammaParticle(61460.0, 0.02017) }, { 0.019530000000000002d, new GammaParticle(180110.0, 0.00688) }, { 0.000357d, new GammaParticle(200380.0, 0.00619) }, { 0.01617d, new GammaParticle(207100.0, 0.00599) }, { 0.000707d, new GammaParticle(241500.0, 0.00513) }, { 0.015609999999999999d, new GammaParticle(261750.0, 0.00474) }, { 8.89e-06d, new GammaParticle(318600.0, 0.00389) }, { 0.00013299999999999998d, new GammaParticle(330500.0, 0.00375) }, { 0.000126d, new GammaParticle(360200.0, 0.00344) }, { 4.9699999999999995e-05d, new GammaParticle(401740.0, 0.00309) }, { 0.0012740000000000002d, new GammaParticle(439500.0, 0.00282) }, { 1.2600000000000001e-05d, new GammaParticle(546400.0, 0.00227) }, { 0.02044d, new GammaParticle(585130.0, 0.00212) }, { 0.018340000000000002d, new GammaParticle(599660.0, 0.00207) }, { 0.000245d, new GammaParticle(671130.0, 0.00185) }, { 8.4e-05d, new GammaParticle(716790.0, 0.00173) }, { 6.300000000000001e-06d, new GammaParticle(778000.0, 0.00159) }, { 0.07d, new GammaParticle(779800.0, 0.00159) }, { 0.000189d, new GammaParticle(811400.0, 0.00153) }, { 0.00301d, new GammaParticle(821080.0, 0.00151) }, { 0.0037099999999999998d, new GammaParticle(841270.0, 0.00147) }, { 0.0028000000000000004d, new GammaParticle(841270.0, 0.00147) }, { 4.9e-05d, new GammaParticle(861000.0, 0.00144) }, { 3.57e-05d, new GammaParticle(868900.0, 0.00143) }, { 0.000644d, new GammaParticle(910630.0, 0.00136) }, { 0.00434d, new GammaParticle(930900.0, 0.00133) }, { 0.000112d, new GammaParticle(989150.0, 0.00125) }, { 0.00028000000000000003d, new GammaParticle(1009350.0, 0.00123) }, { 0.001925d, new GammaParticle(1021560.0, 0.00121) }, { 0.00020299999999999997d, new GammaParticle(1049270.0, 0.00118) }, { 0.000714d, new GammaParticle(1082900.0, 0.00114) }, { 7.7e-05d, new GammaParticle(1091700.0, 0.00114) }, { 0.014839999999999999d, new GammaParticle(1111040.0, 0.00112) }, { 0.012809999999999998d, new GammaParticle(1172380.0, 0.00106) }, { 0.00021700000000000002d, new GammaParticle(1189500.0, 0.00104) }, { 0.000147d, new GammaParticle(1251140.0, 0.00099) }, { 4.9699999999999995e-05d, new GammaParticle(1263200.0, 0.00098) }, { 5.0400000000000005e-05d, new GammaParticle(1292200.0, 0.00096) }, { 1.47e-05d, new GammaParticle(1324700.0, 0.00094) }, { 4.9e-06d, new GammaParticle(1339800.0, 0.00093) }, { 0.00010149999999999999d, new GammaParticle(1353700.0, 0.00092) }, { 1.33e-05d, new GammaParticle(1368300.0, 0.00091) }, { 1.82e-05d, new GammaParticle(1372000.0, 0.0009) }, { 8.400000000000001e-06d, new GammaParticle(1432600.0, 0.00087) }, { 9.8e-06d, new GammaParticle(1443200.0, 0.00086) }, { 0.0013d, new GammaParticle(511000.0, 0.00243) }, { 0.4917233120084446d, new GammaParticle(11419.0, 0.10858) }, { 0.22942257911985775d, new GammaParticle(66991.0, 0.01851) }, { 0.390572998161147d, new GammaParticle(68806.0, 0.01802) }, { 0.13179114676105144d, new GammaParticle(78048.0, 0.01589) }, { 0.16987878817499533d, new GammaParticle(78983.0, 0.0157) }, { 0.03808764141394387d, new GammaParticle(80133.0, 0.01547) } } },

        };
    }
}
    
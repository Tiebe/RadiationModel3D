using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium249";
        public override double halfLife { get; } = 6132.0d;
        public override double atomicWeight { get; } = 249.07641d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9943000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Berkelium249() }, { 1.0d, new BetaParticle(1, 666849.99999) }, { 0.00033d, new GammaParticle(43000.0, 0.02883) }, { 0.00032d, new GammaParticle(55140.0, 0.02249) }, { 0.00043999999999999996d, new GammaParticle(58010.0, 0.02137) }, { 0.00128d, new GammaParticle(62470.0, 0.01985) }, { 5e-06d, new GammaParticle(63100.0, 0.01965) }, { 0.00058d, new GammaParticle(63450.0, 0.01954) }, { 1.6e-05d, new GammaParticle(73700.0, 0.01682) }, { 0.000153d, new GammaParticle(136200.0, 0.0091) }, { 0.00065d, new GammaParticle(136370.0, 0.00909) }, { 0.0018d, new GammaParticle(144990.0, 0.00855) }, { 0.004d, new GammaParticle(191600.0, 0.00647) }, { 0.0026d, new GammaParticle(234600.0, 0.00528) }, { 0.0011d, new GammaParticle(255000.0, 0.00486) }, { 0.005600000000000001d, new GammaParticle(298000.0, 0.00416) }, { 0.0014000000000000002d, new GammaParticle(370100.0, 0.00335) }, { 0.033d, new GammaParticle(375100.0, 0.00331) }, { 0.41d, new GammaParticle(379500.0, 0.00327) }, { 0.00062d, new GammaParticle(433700.0, 0.00286) }, { 0.0075d, new GammaParticle(437600.0, 0.00283) }, { 0.00031d, new GammaParticle(443100.0, 0.0028) }, { 0.0004d, new GammaParticle(507300.0, 0.00244) }, { 0.0021d, new GammaParticle(565000.0, 0.00219) }, { 0.00054d, new GammaParticle(570300.0, 0.00217) }, { 0.0003d, new GammaParticle(609200.0, 0.00204) }, { 0.00131d, new GammaParticle(625300.0, 0.00198) }, { 0.0021d, new GammaParticle(628500.0, 0.00197) }, { 0.0001d, new GammaParticle(664000.0, 0.00187) }, { 0.0024d, new GammaParticle(668300.0, 0.00186) }, { 0.0003d, new GammaParticle(707000.0, 0.00175) }, { 0.001d, new GammaParticle(766300.0, 0.00162) }, { 0.001d, new GammaParticle(766300.0, 0.00162) }, { 0.0115d, new GammaParticle(789700.0, 0.00157) }, { 0.092d, new GammaParticle(813200.0, 0.00152) }, { 0.0001d, new GammaParticle(820500.0, 0.00151) }, { 0.00097d, new GammaParticle(840000.0, 0.00148) }, { 0.0088d, new GammaParticle(852200.0, 0.00145) }, { 0.00017999999999999998d, new GammaParticle(862800.0, 0.00144) }, { 0.00017999999999999998d, new GammaParticle(902600.0, 0.00137) }, { 0.0024d, new GammaParticle(945400.0, 0.00131) }, { 0.0002d, new GammaParticle(1000500.0, 0.00124) }, { 0.0073d, new GammaParticle(1007900.0, 0.00123) }, { 0.0001d, new GammaParticle(1021400.0, 0.00121) }, { 0.00031d, new GammaParticle(1093200.0, 0.00113) }, { 0.0001d, new GammaParticle(1137300.0, 0.00109) }, { 0.00016d, new GammaParticle(1199800.0, 0.00103) }, { 0.0003d, new GammaParticle(1205100.0, 0.00103) }, { 0.0152d, new GammaParticle(1218500.0, 0.00102) }, { 0.00023d, new GammaParticle(1238000.0, 0.001) }, { 6e-05d, new GammaParticle(1267800.0, 0.00098) }, { 0.00037999999999999997d, new GammaParticle(1304300.0, 0.00095) }, { 5e-05d, new GammaParticle(511000.0, 0.00243) }, { 0.57d, new GammaParticle(19579.0, 0.06333) }, { 0.235d, new GammaParticle(109867.0, 0.01128) }, { 0.36d, new GammaParticle(115063.0, 0.01078) }, { 0.138d, new GammaParticle(129671.0, 0.00956) }, { 0.188d, new GammaParticle(131332.0, 0.00944) }, { 0.049d, new GammaParticle(133529.0, 0.00929) } } },
            { 0.005699999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Berkelium245() }, { 1.0d, new AlphaParticle(7963202.09) } } },

        };
    }
}
    
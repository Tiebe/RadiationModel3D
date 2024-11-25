using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury193 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury193";
        public override double halfLife { get; } = 13680.0d;
        public override double atomicWeight { get; } = 192.96665d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum193() }, { 1.0d, new BetaParticle(1, 1708849.99999) }, { 3.6e-07d, new GammaParticle(32210.0, 0.03849) }, { 0.0058d, new GammaParticle(38240.0, 0.03242) }, { 0.0005d, new GammaParticle(126560.0, 0.0098) }, { 0.15d, new GammaParticle(186560.0, 0.00665) }, { 0.027000000000000003d, new GammaParticle(218070.0, 0.00569) }, { 0.004699999999999999d, new GammaParticle(219750.0, 0.00564) }, { 0.0101d, new GammaParticle(224810.0, 0.00552) }, { 0.087d, new GammaParticle(258000.0, 0.00481) }, { 0.011000000000000001d, new GammaParticle(289000.0, 0.00429) }, { 0.15d, new GammaParticle(381600.0, 0.00325) }, { 0.0067d, new GammaParticle(446500.0, 0.00278) }, { 0.00047d, new GammaParticle(567200.0, 0.00219) }, { 0.04d, new GammaParticle(580970.0, 0.00213) }, { 0.044000000000000004d, new GammaParticle(789210.0, 0.00157) }, { 0.038d, new GammaParticle(827810.0, 0.0015) }, { 0.121d, new GammaParticle(861110.0, 0.00144) }, { 0.0074d, new GammaParticle(920000.0, 0.00135) }, { 0.009000000000000001d, new GammaParticle(953700.0, 0.0013) }, { 0.022000000000000002d, new GammaParticle(1040500.0, 0.00119) }, { 0.036000000000000004d, new GammaParticle(1080700.0, 0.00115) }, { 0.0054d, new GammaParticle(1094500.0, 0.00113) }, { 0.078d, new GammaParticle(1118840.0, 0.00111) }, { 0.0026d, new GammaParticle(1221100.0, 0.00102) }, { 0.025d, new GammaParticle(1276380.0, 0.00097) }, { 0.005699999999999999d, new GammaParticle(1378500.0, 0.0009) }, { 0.0011d, new GammaParticle(1565000.0, 0.00079) }, { 0.02d, new GammaParticle(1603400.0, 0.00077) }, { 0.02d, new GammaParticle(1603400.0, 0.00077) }, { 0.0058d, new GammaParticle(1662100.0, 0.00075) }, { 0.003d, new GammaParticle(1756700.0, 0.00071) }, { 0.008d, new GammaParticle(1776400.0, 0.0007) }, { 0.025d, new GammaParticle(1815600.0, 0.00068) }, { 0.005d, new GammaParticle(1824300.0, 0.00068) }, { 0.013999999999999999d, new GammaParticle(1862200.0, 0.00067) }, { 0.017d, new GammaParticle(1976600.0, 0.00063) }, { 0.00054d, new GammaParticle(2014600.0, 0.00062) }, { 0.021943999999999998d, new GammaParticle(511000.0, 0.00243) }, { 0.51d, new GammaParticle(11419.0, 0.10858) }, { 0.3d, new GammaParticle(66991.0, 0.01851) }, { 0.5d, new GammaParticle(68806.0, 0.01802) }, { 0.17d, new GammaParticle(78048.0, 0.01589) }, { 0.21899999999999997d, new GammaParticle(78983.0, 0.0157) }, { 0.049d, new GammaParticle(80133.0, 0.01547) } } },

        };
    }
}
    
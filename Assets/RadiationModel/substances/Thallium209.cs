using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium209";
        public override double halfLife { get; } = 129.72d;
        public override double atomicWeight { get; } = 208.98535d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead209() }, { 1.0d, new BetaParticle(-1, 1984800.0) }, { 0.7574388000000001d, new GammaParticle(117210.0, 0.01058) }, { 0.0013952819999999999d, new GammaParticle(284040.0, 0.00437) }, { 0.0002790564d, new GammaParticle(311500.0, 0.00398) }, { 0.0006976409999999999d, new GammaParticle(375500.0, 0.0033) }, { 0.95377491d, new GammaParticle(465140.0, 0.00267) }, { 0.000298989d, new GammaParticle(469700.0, 0.00264) }, { 0.003089553d, new GammaParticle(582400.0, 0.00213) }, { 0.0007973040000000001d, new GammaParticle(748300.0, 0.00166) }, { 0.001096293d, new GammaParticle(755600.0, 0.00164) }, { 0.002591238d, new GammaParticle(860500.0, 0.00144) }, { 0.005880117000000001d, new GammaParticle(873500.0, 0.00142) }, { 0.001195956d, new GammaParticle(890000.0, 0.00139) }, { 0.00099663d, new GammaParticle(902800.0, 0.00137) }, { 0.0062987016d, new GammaParticle(920530.0, 0.00135) }, { 0.004385172d, new GammaParticle(1239730.0, 0.001) }, { 0.00099663d, new GammaParticle(1329300.0, 0.00093) }, { 0.99663d, new GammaParticle(1567080.0, 0.00079) }, { 0.00099663d, new GammaParticle(1661100.0, 0.00075) }, { 0.004783824d, new GammaParticle(1673200.0, 0.00074) }, { 0.00039865200000000004d, new GammaParticle(1781700.0, 0.0007) }, { 9.966300000000001e-06d, new GammaParticle(2032100.0, 0.00061) }, { 0.0001494945d, new GammaParticle(2149000.0, 0.00058) }, { 0.00028403955d, new GammaParticle(2315900.0, 0.00054) }, { 0.07900072704904687d, new GammaParticle(12522.0, 0.09901) }, { 0.05736953650410493d, new GammaParticle(72805.0, 0.01703) }, { 0.0964193890825293d, new GammaParticle(74970.0, 0.01654) }, { 0.03295476976856448d, new GammaParticle(84986.0, 0.01459) }, { 0.04290711023867095d, new GammaParticle(86022.0, 0.01441) }, { 0.009952340470106472d, new GammaParticle(87301.0, 0.0142) } } },

        };
    }
}
    
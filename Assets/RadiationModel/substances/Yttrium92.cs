using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium92 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium92";
        public override double halfLife { get; } = 12744.0d;
        public override double atomicWeight { get; } = 91.90895d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium92() }, { 1.0d, new BetaParticle(-1, 1821510.0) }, { 0.023351999999999998d, new GammaParticle(448500.0, 0.00276) }, { 0.0048511d, new GammaParticle(492600.0, 0.00252) }, { 0.024047d, new GammaParticle(561100.0, 0.00221) }, { 0.012509999999999999d, new GammaParticle(844300.0, 0.00147) }, { 0.006254999999999999d, new GammaParticle(912800.0, 0.00136) }, { 0.139d, new GammaParticle(934470.0, 0.00133) }, { 0.0006811d, new GammaParticle(972300.0, 0.00128) }, { 0.0024324999999999998d, new GammaParticle(1132400.0, 0.00109) }, { 0.047816d, new GammaParticle(1405400.0, 0.00088) }, { 0.0036001d, new GammaParticle(1847300.0, 0.00067) }, { 0.000278d, new GammaParticle(1885100.0, 0.00066) }, { 6.116e-05d, new GammaParticle(1988600.0, 0.00062) }, { 1.3899999999999999e-05d, new GammaParticle(2067000.0, 0.0006) }, { 0.00019043d, new GammaParticle(2105600.0, 0.00059) }, { 0.00014317d, new GammaParticle(2339900.0, 0.00053) }, { 3.058e-05d, new GammaParticle(2437000.0, 0.00051) }, { 2.641e-05d, new GammaParticle(2473400.0, 0.0005) }, { 4.1700000000000004e-05d, new GammaParticle(2819800.0, 0.00044) }, { 1.1119999999999999e-05d, new GammaParticle(3263900.0, 0.00038) }, { 3.058e-05d, new GammaParticle(3371200.0, 0.00037) }, { 1.1271487247656398e-05d, new GammaParticle(2161.0, 0.57374) }, { 6.386786525088117e-05d, new GammaParticle(15691.0, 0.07902) }, { 0.00012223514880551421d, new GammaParticle(15775.0, 0.0786) }, { 3.1147083853417664e-05d, new GammaParticle(17736.0, 0.06991) }, { 3.569455809601664e-05d, new GammaParticle(17824.0, 0.06956) }, { 4.547474242598979e-06d, new GammaParticle(17968.0, 0.069) } } },

        };
    }
}
    
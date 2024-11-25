using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron63 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron63";
        public override double halfLife { get; } = 6.1d;
        public override double atomicWeight { get; } = 62.94027d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt63() }, { 1.0d, new BetaParticle(-1, 3108000.0) }, { 0.0003d, new GammaParticle(149700.0, 0.00828) }, { 0.0007000000000000001d, new GammaParticle(357200.0, 0.00347) }, { 0.0014000000000000002d, new GammaParticle(368600.0, 0.00336) }, { 0.0007000000000000001d, new GammaParticle(417600.0, 0.00297) }, { 0.0062d, new GammaParticle(432100.0, 0.00287) }, { 0.001d, new GammaParticle(461300.0, 0.00269) }, { 0.002d, new GammaParticle(499600.0, 0.00248) }, { 0.0021d, new GammaParticle(582000.0, 0.00213) }, { 0.0018d, new GammaParticle(893800.0, 0.00139) }, { 0.14d, new GammaParticle(994800.0, 0.00125) }, { 0.0013d, new GammaParticle(1100500.0, 0.00113) }, { 0.0124d, new GammaParticle(1299000.0, 0.00095) }, { 0.04650000000000001d, new GammaParticle(1427200.0, 0.00087) }, { 0.0113d, new GammaParticle(1494600.0, 0.00083) }, { 0.002d, new GammaParticle(1543000.0, 0.0008) }, { 0.0034999999999999996d, new GammaParticle(1799300.0, 0.00069) }, { 0.0055000000000000005d, new GammaParticle(2154000.0, 0.00058) }, { 0.0021d, new GammaParticle(2427000.0, 0.00051) }, { 0.0011d, new GammaParticle(2796000.0, 0.00044) } } },

        };
    }
}
    
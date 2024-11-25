using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium96";
        public override double halfLife { get; } = 84060.0d;
        public override double atomicWeight { get; } = 95.9081d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum96() }, { 1.0d, new BetaParticle(-1, 1596030.0) }, { 0.00044366999999999996d, new GammaParticle(108950.0, 0.01138) }, { 0.000241125d, new GammaParticle(120300.0, 0.01031) }, { 0.00016396500000000002d, new GammaParticle(128000.0, 0.00969) }, { 0.0297066d, new GammaParticle(219081.0, 0.00566) }, { 0.034722d, new GammaParticle(241377.0, 0.00514) }, { 0.0075231000000000004d, new GammaParticle(241380.0, 0.00514) }, { 0.000742665d, new GammaParticle(314340.0, 0.00394) }, { 0.000607635d, new GammaParticle(316270.0, 0.00392) }, { 0.0048225d, new GammaParticle(350053.0, 0.00354) }, { 0.010609500000000001d, new GammaParticle(350053.0, 0.00354) }, { 0.0082947d, new GammaParticle(352560.0, 0.00352) }, { 0.0262344d, new GammaParticle(371807.0, 0.00333) }, { 0.0037615500000000002d, new GammaParticle(434730.0, 0.00285) }, { 0.266202d, new GammaParticle(460040.0, 0.0027) }, { 0.05835225d, new GammaParticle(480705.0, 0.00258) }, { 0.5796645d, new GammaParticle(568871.0, 0.00218) }, { 0.00935565d, new GammaParticle(591240.0, 0.0021) }, { 0.0030864000000000004d, new GammaParticle(593250.0, 0.00209) }, { 0.0684795d, new GammaParticle(719562.0, 0.00172) }, { 0.0102237d, new GammaParticle(721629.0, 0.00172) }, { 0.9645d, new GammaParticle(778224.0, 0.00159) }, { 0.11091749999999999d, new GammaParticle(810330.0, 0.00153) }, { 0.029513699999999997d, new GammaParticle(812581.0, 0.00153) }, { 0.0113811d, new GammaParticle(847690.0, 0.00146) }, { 0.204474d, new GammaParticle(849929.0, 0.00146) }, { 0.4851435d, new GammaParticle(1091349.0, 0.00114) }, { 0.0042438d, new GammaParticle(1126965.0, 0.0011) }, { 0.1996515d, new GammaParticle(1200231.0, 0.00103) }, { 0.000241125d, new GammaParticle(1346900.0, 0.00092) }, { 0.0044367d, new GammaParticle(1441129.0, 0.00086) }, { 0.032793d, new GammaParticle(1497807.0, 0.00083) }, { 0.0015432000000000002d, new GammaParticle(1625900.0, 0.00076) }, { 0.0003235989280131546d, new GammaParticle(2440.0, 0.50813) }, { 0.0016318778089586948d, new GammaParticle(17374.0, 0.07136) }, { 0.0031101158928124543d, new GammaParticle(17479.0, 0.07093) }, { 0.0008160831448628684d, new GammaParticle(19681.0, 0.063) }, { 0.0009417599491717501d, new GammaParticle(19794.0, 0.06264) }, { 0.00012567680430888175d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    
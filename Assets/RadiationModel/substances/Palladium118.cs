using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium118";
        public override double halfLife { get; } = 1.9d;
        public override double atomicWeight { get; } = 117.91907d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver118() }, { 1.0d, new BetaParticle(-1, 2082700.0) }, { 0.01008d, new GammaParticle(29800.0, 0.04161) }, { 0.08064d, new GammaParticle(45800.0, 0.02707) }, { 0.08694d, new GammaParticle(49800.0, 0.0249) }, { 0.00945d, new GammaParticle(51000.0, 0.02431) }, { 0.05418d, new GammaParticle(78500.0, 0.01579) }, { 0.01008d, new GammaParticle(78500.0, 0.01579) }, { 0.013859999999999999d, new GammaParticle(91400.0, 0.01357) }, { 0.0063d, new GammaParticle(96800.0, 0.01281) }, { 0.00945d, new GammaParticle(108000.0, 0.01148) }, { 0.32130000000000003d, new GammaParticle(125400.0, 0.00989) }, { 0.30870000000000003d, new GammaParticle(125400.0, 0.00989) }, { 0.03213d, new GammaParticle(127600.0, 0.00972) }, { 0.12096d, new GammaParticle(145600.0, 0.00852) }, { 0.1386d, new GammaParticle(151600.0, 0.00818) }, { 0.041580000000000006d, new GammaParticle(157100.0, 0.00789) }, { 0.023940000000000003d, new GammaParticle(205200.0, 0.00604) }, { 0.18648d, new GammaParticle(224200.0, 0.00553) }, { 0.02835d, new GammaParticle(233000.0, 0.00532) }, { 0.0252d, new GammaParticle(251000.0, 0.00494) }, { 0.03528d, new GammaParticle(271000.0, 0.00458) }, { 0.04473d, new GammaParticle(271000.0, 0.00458) }, { 0.11277d, new GammaParticle(283700.0, 0.00437) }, { 0.03465d, new GammaParticle(300800.0, 0.00412) }, { 0.027719999999999998d, new GammaParticle(321000.0, 0.00386) }, { 0.07812000000000001d, new GammaParticle(349600.0, 0.00355) }, { 0.13545d, new GammaParticle(379500.0, 0.00327) }, { 0.0063d, new GammaParticle(429500.0, 0.00289) }, { 0.06174d, new GammaParticle(469600.0, 0.00264) }, { 0.0315d, new GammaParticle(595700.0, 0.00208) }, { 0.059202231256674d, new GammaParticle(3218.0, 0.38528) }, { 0.21324746592992522d, new GammaParticle(21990.0, 0.05638) }, { 0.4019744880865697d, new GammaParticle(22163.0, 0.05594) }, { 0.11135831791184428d, new GammaParticle(25030.0, 0.04953) }, { 0.1307346652285052d, new GammaParticle(25211.0, 0.04918) }, { 0.019376347316660904d, new GammaParticle(25454.0, 0.04871) } } },

        };
    }
}
    
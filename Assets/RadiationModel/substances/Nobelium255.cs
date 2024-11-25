using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium255";
        public override double halfLife { get; } = 211.2d;
        public override double atomicWeight { get; } = 255.0932d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fermium255() }, { 1.0d, new BetaParticle(1, 1506000.0) } } },
            { 0.3d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fermium251() }, { 1.0d, new AlphaParticle(9450002.09) }, { 0.0004d, new GammaParticle(63900.0, 0.0194) }, { 0.0025d, new GammaParticle(163300.0, 0.00759) }, { 0.0012d, new GammaParticle(166700.0, 0.00744) }, { 0.03d, new GammaParticle(191950.0, 0.00646) }, { 0.0039000000000000003d, new GammaParticle(195200.0, 0.00635) }, { 0.009300000000000001d, new GammaParticle(200070.0, 0.0062) }, { 0.0012d, new GammaParticle(353800.0, 0.0035) }, { 0.0072d, new GammaParticle(358400.0, 0.00346) }, { 0.14903512857576d, new GammaParticle(20618.0, 0.06013) }, { 0.04873615109813666d, new GammaParticle(115320.0, 0.01075) }, { 0.07454290470807075d, new GammaParticle(121090.0, 0.01024) }, { 0.02909748302484748d, new GammaParticle(136318.0, 0.0091) }, { 0.039572576913792575d, new GammaParticle(138067.0, 0.00898) }, { 0.010475093888945092d, new GammaParticle(140406.0, 0.00883) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum150 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum150";
        public override double halfLife { get; } = 0.59d;
        public override double atomicWeight { get; } = 149.93955d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium150() }, { 1.0d, new BetaParticle(-1, 4267950.0) }, { 0.2957d, new GammaParticle(97000.0, 0.01278) }, { 0.24600000000000002d, new GammaParticle(208700.0, 0.00594) }, { 0.07494640030000001d, new GammaParticle(5410.0, 0.22918) }, { 0.10916484029477132d, new GammaParticle(34279.0, 0.03617) }, { 0.1999356049354786d, new GammaParticle(34720.0, 0.03571) }, { 0.06021789375578154d, new GammaParticle(39366.0, 0.0315) }, { 0.07551323876975005d, new GammaParticle(39753.0, 0.03119) }, { 0.01529534501396851d, new GammaParticle(40229.0, 0.03082) } } },
            { 0.027000000000000003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium150() }, { 1.0d, new BetaParticle(-1, 4267950.0) }, { 0.2957d, new GammaParticle(97000.0, 0.01278) }, { 0.24600000000000002d, new GammaParticle(208700.0, 0.00594) }, { 0.07494640030000001d, new GammaParticle(5410.0, 0.22918) }, { 0.10916484029477132d, new GammaParticle(34279.0, 0.03617) }, { 0.1999356049354786d, new GammaParticle(34720.0, 0.03571) }, { 0.06021789375578154d, new GammaParticle(39366.0, 0.0315) }, { 0.07551323876975005d, new GammaParticle(39753.0, 0.03119) }, { 0.01529534501396851d, new GammaParticle(40229.0, 0.03082) } } },

        };
    }
}
    
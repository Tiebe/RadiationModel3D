using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine25 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine25";
        public override double halfLife { get; } = 0.08d;
        public override double atomicWeight { get; } = 25.01216d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon25() }, { 1.0d, new BetaParticle(-1, 6683000.0) }, { 0.14d, new GammaParticle(574700.0, 0.00216) }, { 0.08d, new GammaParticle(1234000.0, 0.001) }, { 0.17d, new GammaParticle(1613400.0, 0.00077) }, { 0.11d, new GammaParticle(1622000.0, 0.00076) }, { 0.56d, new GammaParticle(1702700.0, 0.00073) }, { 0.18d, new GammaParticle(2090000.0, 0.00059) }, { 0.1d, new GammaParticle(2188600.0, 0.00057) } } },
            { 0.231d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon25() }, { 1.0d, new BetaParticle(-1, 6683000.0) }, { 0.14d, new GammaParticle(574700.0, 0.00216) }, { 0.08d, new GammaParticle(1234000.0, 0.001) }, { 0.17d, new GammaParticle(1613400.0, 0.00077) }, { 0.11d, new GammaParticle(1622000.0, 0.00076) }, { 0.56d, new GammaParticle(1702700.0, 0.00073) }, { 0.18d, new GammaParticle(2090000.0, 0.00059) }, { 0.1d, new GammaParticle(2188600.0, 0.00057) } } },

        };
    }
}
    
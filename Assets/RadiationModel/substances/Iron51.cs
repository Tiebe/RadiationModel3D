using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron51 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron51";
        public override double halfLife { get; } = 0.305d;
        public override double atomicWeight { get; } = 50.95686d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium51() }, { 1.0d, new BetaParticle(1, 5630755.0) }, { 0.05d, new GammaParticle(237000.0, 0.00523) }, { 0.0049d, new GammaParticle(1825000.0, 0.00068) }, { 0.0024d, new GammaParticle(2140000.0, 0.00058) }, { 0.001d, new GammaParticle(2914000.0, 0.00043) }, { 0.002d, new GammaParticle(3426000.0, 0.00036) }, { 0.0016d, new GammaParticle(3555000.0, 0.00035) }, { 1.9978d, new GammaParticle(511000.0, 0.00243) }, { 8.17595058803e-06d, new GammaParticle(660.0, 1.87855) }, { 0.00010496915324273127d, new GammaParticle(5888.0, 0.21057) }, { 0.00020586223424736469d, new GammaParticle(5899.0, 0.21018) }, { 4.2241985559904044e-05d, new GammaParticle(6512.0, 0.19039) }, { 4.2241985559904044e-05d, new GammaParticle(6512.0, 0.19039) } } },

        };
    }
}
    
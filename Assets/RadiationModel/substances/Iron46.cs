using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron46 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron46";
        public override double halfLife { get; } = 0.013d;
        public override double atomicWeight { get; } = 46.0013d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium46() }, { 1.0d, new BetaParticle(1, 15341000.0) }, { 0.4d, new GammaParticle(511000.0, 0.00243) }, { 1.2942484e-06d, new GammaParticle(660.0, 1.87855) }, { 1.6605463715864062e-05d, new GammaParticle(5888.0, 0.21057) }, { 3.2566118289594164e-05d, new GammaParticle(5899.0, 0.21018) }, { 6.682417994541773e-06d, new GammaParticle(6512.0, 0.19039) }, { 6.682417994541773e-06d, new GammaParticle(6512.0, 0.19039) } } },
            { 0.787d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium45() }, { 1.0d, new ProtonParticle() }, { 0.23d, new GammaParticle(493600.0, 0.00251) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium46 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium46";
        public override double halfLife { get; } = 0.26d;
        public override double atomicWeight { get; } = 45.96836d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium46() }, { 1.0d, new BetaParticle(1, 7328135.0) }, { 2.0d, new GammaParticle(511000.0, 0.00243) }, { 4.995645938335079e-06d, new GammaParticle(536.0, 2.31314) }, { 6.079671485319471e-05d, new GammaParticle(4945.0, 0.25073) }, { 0.00011960793793664118d, new GammaParticle(4952.0, 0.25037) }, { 2.406598068216411e-05d, new GammaParticle(5444.0, 0.22774) }, { 2.406598068216411e-05d, new GammaParticle(5444.0, 0.22774) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium45 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium45";
        public override double halfLife { get; } = 0.0609d;
        public override double atomicWeight { get; } = 44.97906d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium45() }, { 1.0d, new BetaParticle(1, 6188200.0) }, { 0.11d, new GammaParticle(1322700.0, 0.00094) }, { 0.392d, new GammaParticle(511000.0, 0.00243) }, { 7.840681296e-07d, new GammaParticle(536.0, 2.31314) }, { 9.548280768302343e-06d, new GammaParticle(4945.0, 0.25073) }, { 1.8784734936656192e-05d, new GammaParticle(4952.0, 0.25037) }, { 3.7796242950414685e-06d, new GammaParticle(5444.0, 0.22774) }, { 3.7796242950414685e-06d, new GammaParticle(5444.0, 0.22774) } } },
            { 0.344d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium44() }, { 1.0d, new BetaParticle(1, 474766351.736) }, { 1.0d, new ProtonParticle() }, { 0.27699999999999997d, new GammaParticle(1083300.0, 0.00114) }, { 0.021d, new GammaParticle(1370000.0, 0.0009) }, { 1.39506072276e-07d, new GammaParticle(477.0, 2.59925) }, { 1.7638493579023014e-06d, new GammaParticle(4505.0, 0.27521) }, { 3.474880531722422e-06d, new GammaParticle(4511.0, 0.27485) }, { 6.941317103752757e-07d, new GammaParticle(4947.0, 0.25063) }, { 6.941317103752757e-07d, new GammaParticle(4947.0, 0.25063) } } },

        };
    }
}
    
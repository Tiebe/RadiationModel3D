using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon27 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon27";
        public override double halfLife { get; } = 0.0315d;
        public override double atomicWeight { get; } = 27.00757d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium27() }, { 1.0d, new BetaParticle(-1, 6284000.0) }, { 0.21100000000000002d, new GammaParticle(63000.0, 0.01968) }, { 0.03d, new GammaParticle(1665000.0, 0.00074) }, { 0.0043d, new GammaParticle(1728000.0, 0.00072) }, { 0.032d, new GammaParticle(2067000.0, 0.0006) }, { 0.0098d, new GammaParticle(2129000.0, 0.00058) }, { 0.043d, new GammaParticle(2225000.0, 0.00056) }, { 0.059000000000000004d, new GammaParticle(2736000.0, 0.00045) }, { 0.03d, new GammaParticle(2799000.0, 0.00044) }, { 0.027000000000000003d, new GammaParticle(2956000.0, 0.00042) }, { 0.084d, new GammaParticle(3019000.0, 0.00041) }, { 0.016d, new GammaParticle(3508000.0, 0.00035) }, { 0.013000000000000001d, new GammaParticle(3582000.0, 0.00035) }, { 0.026000000000000002d, new GammaParticle(3685000.0, 0.00034) }, { 0.032d, new GammaParticle(3781000.0, 0.00033) } } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium27() }, { 1.0d, new BetaParticle(-1, 6284000.0) }, { 0.21100000000000002d, new GammaParticle(63000.0, 0.01968) }, { 0.03d, new GammaParticle(1665000.0, 0.00074) }, { 0.0043d, new GammaParticle(1728000.0, 0.00072) }, { 0.032d, new GammaParticle(2067000.0, 0.0006) }, { 0.0098d, new GammaParticle(2129000.0, 0.00058) }, { 0.043d, new GammaParticle(2225000.0, 0.00056) }, { 0.059000000000000004d, new GammaParticle(2736000.0, 0.00045) }, { 0.03d, new GammaParticle(2799000.0, 0.00044) }, { 0.027000000000000003d, new GammaParticle(2956000.0, 0.00042) }, { 0.084d, new GammaParticle(3019000.0, 0.00041) }, { 0.016d, new GammaParticle(3508000.0, 0.00035) }, { 0.013000000000000001d, new GammaParticle(3582000.0, 0.00035) }, { 0.026000000000000002d, new GammaParticle(3685000.0, 0.00034) }, { 0.032d, new GammaParticle(3781000.0, 0.00033) } } },

        };
    }
}
    
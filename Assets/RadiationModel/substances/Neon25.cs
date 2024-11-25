using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon25 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon25";
        public override double halfLife { get; } = 0.602d;
        public override double atomicWeight { get; } = 24.99781d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium25() }, { 1.0d, new BetaParticle(-1, 3660900.0) }, { 0.9540000000000001d, new GammaParticle(89530.0, 0.01385) }, { 0.18100000000000002d, new GammaParticle(979770.0, 0.00127) }, { 0.023399999999999997d, new GammaParticle(1069300.0, 0.00116) }, { 0.004d, new GammaParticle(1132800.0, 0.00109) }, { 0.0062d, new GammaParticle(2112500.0, 0.00059) }, { 0.011000000000000001d, new GammaParticle(2202000.0, 0.00056) }, { 0.0053d, new GammaParticle(3220000.0, 0.00039) }, { 0.0022d, new GammaParticle(3599000.0, 0.00034) }, { 0.0096d, new GammaParticle(3688000.0, 0.00034) }, { 2.744591961539732e-05d, new GammaParticle(1041.0, 1.19101) }, { 5.457530247643134e-05d, new GammaParticle(1041.0, 1.19101) } } },

        };
    }
}
    
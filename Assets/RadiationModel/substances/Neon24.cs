using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon24 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon24";
        public override double halfLife { get; } = 202.8d;
        public override double atomicWeight { get; } = 23.99361d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium24() }, { 1.0d, new BetaParticle(-1, 1233150.5) }, { 1.0d, new GammaParticle(472202.3, 0.00263) }, { 0.079d, new GammaParticle(874420.0, 0.00142) }, { 3.124068781052124e-06d, new GammaParticle(1041.0, 1.19101) }, { 6.212107339534945e-06d, new GammaParticle(1041.0, 1.19101) } } },

        };
    }
}
    
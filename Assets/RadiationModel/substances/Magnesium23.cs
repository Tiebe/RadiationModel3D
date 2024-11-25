using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium23 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium23";
        public override double halfLife { get; } = 11.3046d;
        public override double atomicWeight { get; } = 22.99412d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon23() }, { 1.0d, new BetaParticle(1, -159810.0) }, { 0.0785d, new GammaParticle(440500.0, 0.00281) }, { 2.5e-05d, new GammaParticle(1950600.0, 0.00064) }, { 4.4000000000000006e-05d, new GammaParticle(2390600.0, 0.00052) }, { 1.99852d, new GammaParticle(511000.0, 0.00243) }, { 5.066196321798483e-06d, new GammaParticle(1041.0, 1.19101) }, { 1.0073963654401439e-05d, new GammaParticle(1041.0, 1.19101) } } },

        };
    }
}
    
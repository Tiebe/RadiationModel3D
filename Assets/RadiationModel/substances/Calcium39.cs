using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium39 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium39";
        public override double halfLife { get; } = 0.8603d;
        public override double atomicWeight { get; } = 38.97071d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon39() }, { 1.0d, new BetaParticle(1, 2979650.0) }, { 2.5e-05d, new GammaParticle(2522200.0, 0.00049) }, { 1.9985758000000002d, new GammaParticle(511000.0, 0.00243) }, { 2.2e-06d, new GammaParticle(311.0, 3.98663) }, { 2.97e-05d, new GammaParticle(3311.0, 0.37446) }, { 5.8700000000000004e-05d, new GammaParticle(3314.0, 0.37412) }, { 1.08e-05d, new GammaParticle(3591.0, 0.34526) }, { 1.08e-05d, new GammaParticle(3591.0, 0.34526) } } },

        };
    }
}
    
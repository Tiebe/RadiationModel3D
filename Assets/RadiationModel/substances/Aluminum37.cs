using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum37 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum37";
        public override double halfLife { get; } = 0.0107d;
        public override double atomicWeight { get; } = 37.01053d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon37() }, { 1.0d, new BetaParticle(-1, 8190000.0) }, { 0.4d, new GammaParticle(156000.0, 0.00795) }, { 0.38d, new GammaParticle(562000.0, 0.00221) }, { 0.16d, new GammaParticle(717000.0, 0.00173) }, { 0.055999999999999994d, new GammaParticle(1115000.0, 0.00111) }, { 0.044000000000000004d, new GammaParticle(1202000.0, 0.00103) }, { 0.064d, new GammaParticle(1270000.0, 0.00098) }, { 3e-07d, new GammaParticle(118.0, 10.50714) }, { 4e-06d, new GammaParticle(1740.0, 0.71255) }, { 8e-06d, new GammaParticle(1740.0, 0.71255) }, { 3e-07d, new GammaParticle(1836.0, 0.6753) }, { 3e-07d, new GammaParticle(1836.0, 0.6753) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
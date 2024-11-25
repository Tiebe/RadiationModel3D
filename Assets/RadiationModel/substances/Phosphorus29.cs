using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus29 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus29";
        public override double halfLife { get; } = 4.142d;
        public override double atomicWeight { get; } = 28.9818d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum29() }, { 1.0d, new BetaParticle(1, 627500.0) }, { 0.0006468d, new GammaParticle(1152570.0, 0.00108) }, { 0.0132d, new GammaParticle(1273361.0, 0.00097) }, { 4.3559999999999996e-05d, new GammaParticle(2028090.0, 0.00061) }, { 0.0038940000000000003d, new GammaParticle(2425730.0, 0.00051) }, { 1.9987000000000001d, new GammaParticle(511000.0, 0.00243) }, { 8.2e-07d, new GammaParticle(118.0, 10.50714) }, { 1.24e-05d, new GammaParticle(1740.0, 0.71255) }, { 2.45e-05d, new GammaParticle(1740.0, 0.71255) }, { 1.07e-06d, new GammaParticle(1836.0, 0.6753) }, { 1.07e-06d, new GammaParticle(1836.0, 0.6753) } } },

        };
    }
}
    
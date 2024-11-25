using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold184m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold184m";
        public override double halfLife { get; } = 47.6d;
        public override double atomicWeight { get; } = 183.96752d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium184() }, { 1.0d, new BetaParticle(1, 4680000.0) } } },
            { 0.3d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold184() }, { 8.999999999999999e-05d, new GammaParticle(68460.0, 0.01811) }, { 0.0706923d, new GammaParticle(11419.0, 0.10858) } } },
            { 0.00016d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium180() }, { 1.0d, new AlphaParticle(6324002.09) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium47 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium47";
        public override double halfLife { get; } = 289370.88d;
        public override double atomicWeight { get; } = 46.9524d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium47() }, { 1.0d, new BetaParticle(-1, 300405.0) }, { 0.6829999999999999d, new GammaParticle(159381.0, 0.00778) }, { 1.48295088228e-05d, new GammaParticle(477.0, 2.59925) }, { 0.00018631698610659632d, new GammaParticle(4505.0, 0.27521) }, { 0.0003670547401627193d, new GammaParticle(4511.0, 0.27485) }, { 7.332175373068432e-05d, new GammaParticle(4947.0, 0.25063) }, { 7.332175373068432e-05d, new GammaParticle(4947.0, 0.25063) } } },

        };
    }
}
    
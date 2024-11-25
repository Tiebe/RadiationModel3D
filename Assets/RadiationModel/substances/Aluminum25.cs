using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum25 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum25";
        public override double halfLife { get; } = 7.183d;
        public override double atomicWeight { get; } = 24.99043d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium25() }, { 1.0d, new BetaParticle(1, 220915.0) }, { 0.00021999999999999998d, new GammaParticle(389710.0, 0.00318) }, { 0.00021999999999999998d, new GammaParticle(585028.0, 0.00212) }, { 0.00025d, new GammaParticle(974742.0, 0.00127) }, { 0.00788d, new GammaParticle(1611708.0, 0.00077) }, { 1.9972d, new GammaParticle(511000.0, 0.00243) }, { 4.4482487081718003e-07d, new GammaParticle(46.0, 26.95309) }, { 1.4526592948594534e-05d, new GammaParticle(1254.0, 0.98871) }, { 7.308328912437911e-06d, new GammaParticle(1254.0, 0.98871) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium24 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium24";
        public override double halfLife { get; } = 53841.6d;
        public override double atomicWeight { get; } = 23.99096d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium24() }, { 1.0d, new BetaParticle(-1, 2757838.5) }, { 2.1e-05d, new GammaParticle(996830.0, 0.00124) }, { 0.99994d, new GammaParticle(1368625.0, 0.00091) }, { 0.9986700000000001d, new GammaParticle(2754008.0, 0.00045) }, { 2.5e-06d, new GammaParticle(2871000.0, 0.00043) }, { 0.00068d, new GammaParticle(3866150.0, 0.00032) }, { 8.400000000000001e-06d, new GammaParticle(4238900.0, 0.00029) }, { 7.1042874649502995e-09d, new GammaParticle(46.0, 26.95309) }, { 1.1327060045900807e-07d, new GammaParticle(1254.0, 0.98871) }, { 2.2514530005765864e-07d, new GammaParticle(1254.0, 0.98871) } } },

        };
    }
}
    
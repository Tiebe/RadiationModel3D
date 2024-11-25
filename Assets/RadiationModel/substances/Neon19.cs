using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon19 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon19";
        public override double halfLife { get; } = 17.22d;
        public override double atomicWeight { get; } = 19.00188d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen19() }, { 1.0d, new BetaParticle(1, -790425.0) }, { 0.00012d, new GammaParticle(109894.0, 0.01128) }, { 2.0600000000000003e-05d, new GammaParticle(197142.0, 0.00629) }, { 2.0600000000000003e-05d, new GammaParticle(1356843.0, 0.00091) }, { 1.08e-06d, new GammaParticle(1444085.0, 0.00086) }, { 5.7e-07d, new GammaParticle(1553970.0, 0.0008) }, { 1.9980426d, new GammaParticle(511000.0, 0.00243) } } },

        };
    }
}
    
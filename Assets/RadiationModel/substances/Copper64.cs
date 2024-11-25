using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper64 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper64";
        public override double halfLife { get; } = 45722.16d;
        public override double atomicWeight { get; } = 63.92976d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.615d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt64() }, { 1.0d, new BetaParticle(1, -2816200.0) }, { 0.004719999999999999d, new GammaParticle(1345770.0, 0.00092) }, { 0.34979999999999994d, new GammaParticle(511000.0, 0.00243) }, { 0.0049112079873222915d, new GammaParticle(874.0, 1.41858) }, { 0.04896772422139985d, new GammaParticle(7461.0, 0.16618) }, { 0.09556542588095208d, new GammaParticle(7478.0, 0.1658) }, { 0.019916668084104094d, new GammaParticle(8296.0, 0.14945) }, { 0.019916668084104094d, new GammaParticle(8296.0, 0.14945) } } },
            { 0.385d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc64() }, { 1.0d, new BetaParticle(-1, 289800.0) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel49 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel49";
        public override double halfLife { get; } = 0.0075d;
        public override double atomicWeight { get; } = 49.00916d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron49() }, { 1.0d, new BetaParticle(1, 16640500.0) } } },
            { 0.83d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron48() }, { 1.0d, new BetaParticle(1, 479017051.736) }, { 1.0d, new ProtonParticle() }, { 0.82d, new GammaParticle(969500.0, 0.00128) } } },

        };
    }
}
    
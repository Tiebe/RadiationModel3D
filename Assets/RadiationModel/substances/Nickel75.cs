using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel75 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel75";
        public override double halfLife { get; } = 0.344d;
        public override double atomicWeight { get; } = 74.95251d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper75() }, { 1.0d, new BetaParticle(-1, 5115100.0) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper75() }, { 1.0d, new BetaParticle(-1, 5115100.0) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin136 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin136";
        public override double halfLife { get; } = 0.345d;
        public override double atomicWeight { get; } = 135.9397d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony136() }, { 1.0d, new BetaParticle(-1, 4168500.0) } } },
            { 0.27d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony136() }, { 1.0d, new BetaParticle(-1, 4168500.0) } } },

        };
    }
}
    
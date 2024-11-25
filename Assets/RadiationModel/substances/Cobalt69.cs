using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt69 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt69";
        public override double halfLife { get; } = 0.227d;
        public override double atomicWeight { get; } = 68.9459d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel69() }, { 1.0d, new BetaParticle(-1, 4794500.0) } } },

        };
    }
}
    
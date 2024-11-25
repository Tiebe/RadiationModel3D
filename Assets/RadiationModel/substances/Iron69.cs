using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron69 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron69";
        public override double halfLife { get; } = 0.11d;
        public override double atomicWeight { get; } = 68.95792d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt69() }, { 1.0d, new BetaParticle(-1, 5595000.0) } } },

        };
    }
}
    
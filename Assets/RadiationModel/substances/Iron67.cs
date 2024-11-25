using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron67 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron67";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 66.95093d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt67() }, { 1.0d, new BetaParticle(-1, 4807000.0) } } },

        };
    }
}
    
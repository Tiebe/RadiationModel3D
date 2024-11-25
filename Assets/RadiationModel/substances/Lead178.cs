using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead178 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead178";
        public override double halfLife { get; } = 0.00012d;
        public override double atomicWeight { get; } = 178.00384d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury174() }, { 1.0d, new AlphaParticle(8811002.09) } } },

        };
    }
}
    
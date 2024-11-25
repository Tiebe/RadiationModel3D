using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead187 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead187";
        public override double halfLife { get; } = 15.2d;
        public override double atomicWeight { get; } = 186.98391d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.905d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury187() }, { 1.0d, new BetaParticle(1, 6566000.0) } } },
            { 0.095d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury183() }, { 1.0d, new AlphaParticle(7415002.09) } } },

        };
    }
}
    
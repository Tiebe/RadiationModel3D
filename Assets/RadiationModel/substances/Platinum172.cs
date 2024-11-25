using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum172 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum172";
        public override double halfLife { get; } = 0.0976d;
        public override double atomicWeight { get; } = 171.97734d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.94d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium168() }, { 1.0d, new AlphaParticle(7485002.09) } } },
            { 0.06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium172() }, { 1.0d, new BetaParticle(1, 8068500.0) } } },

        };
    }
}
    
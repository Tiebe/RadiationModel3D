using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead209 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead209";
        public override double halfLife { get; } = 11642.4d;
        public override double atomicWeight { get; } = 208.98109d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth209() }, { 1.0d, new BetaParticle(-1, 322000.0) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead214 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead214";
        public override double halfLife { get; } = 1623.6d;
        public override double atomicWeight { get; } = 213.9998d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1018000.0), new Bismuth214() } },

        };
    }
}
    
    
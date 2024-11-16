using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead209 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead209";
        public override double halfLife { get; } = 11646.0d;
        public override double atomicWeight { get; } = 208.98109d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 644000.0), new Bismuth209() } },

        };
    }
}
    
    
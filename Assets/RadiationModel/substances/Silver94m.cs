using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver94m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver94m";
        public override double halfLife { get; } = 0.47d;
        public override double atomicWeight { get; } = 93.9452d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 15052000.0), new Palladium94() } },

        };
    }
}
    
    
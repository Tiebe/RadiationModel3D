using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus41 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus41";
        public override double halfLife { get; } = 0.101d;
        public override double atomicWeight { get; } = 40.99465d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 14029000.0), new Sulfur41() } },

        };
    }
}
    
    
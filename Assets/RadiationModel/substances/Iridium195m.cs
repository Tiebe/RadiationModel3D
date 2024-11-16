using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium195m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium195m";
        public override double halfLife { get; } = 13464.0d;
        public override double atomicWeight { get; } = 194.96608d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1201900.0), new Platinum195() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum203m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum203m";
        public override double halfLife { get; } = 12.0d;
        public override double atomicWeight { get; } = 202.98053d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5003000.0), new Gold203() } },

        };
    }
}
    
    
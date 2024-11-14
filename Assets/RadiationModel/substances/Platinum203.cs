using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum203 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum203";
        public override double halfLife { get; } = 22.0d;
        public override double atomicWeight { get; } = 202.97906d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3633000.0), new Gold203() } },

        };
    }
}
    
    
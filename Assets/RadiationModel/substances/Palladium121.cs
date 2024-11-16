using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium121";
        public override double halfLife { get; } = 0.29d;
        public override double atomicWeight { get; } = 120.92895d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8221000.0), new Silver121() } },

        };
    }
}
    
    
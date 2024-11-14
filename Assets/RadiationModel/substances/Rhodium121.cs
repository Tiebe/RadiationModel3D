using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium121";
        public override double halfLife { get; } = 0.074d;
        public override double atomicWeight { get; } = 120.93961d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9932000.0), new Palladium121() } },

        };
    }
}
    
    
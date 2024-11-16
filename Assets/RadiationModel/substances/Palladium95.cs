using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium95";
        public override double halfLife { get; } = 7.4d;
        public override double atomicWeight { get; } = 94.92489d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8375000.0), new Rhodium95() } },

        };
    }
}
    
    
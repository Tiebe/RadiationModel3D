using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium194n : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium194n";
        public override double halfLife { get; } = 25.0d;
        public override double atomicWeight { get; } = 193.97104d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5455200.0), new Osmium194() } },

        };
    }
}
    
    
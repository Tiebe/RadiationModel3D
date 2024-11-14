using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese57 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese57";
        public override double halfLife { get; } = 85.4d;
        public override double atomicWeight { get; } = 56.93829d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2695720.0), new Iron57() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese69 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese69";
        public override double halfLife { get; } = 0.0221d;
        public override double atomicWeight { get; } = 68.97277d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 13840000.0), new Iron69() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese65 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese65";
        public override double halfLife { get; } = 0.0919d;
        public override double atomicWeight { get; } = 64.95602d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10251000.0), new Iron65() } },

        };
    }
}
    
    
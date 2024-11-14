using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium111";
        public override double halfLife { get; } = 2.12d;
        public override double atomicWeight { get; } = 110.91757d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5519000.0), new Rhodium111() } },

        };
    }
}
    
    
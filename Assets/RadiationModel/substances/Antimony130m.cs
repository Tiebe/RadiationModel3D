using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony130m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony130m";
        public override double halfLife { get; } = 378.0d;
        public override double atomicWeight { get; } = 129.91167d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5071960.0), new Tellurium130() } },

        };
    }
}
    
    
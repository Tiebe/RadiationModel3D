using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony130 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony130";
        public override double halfLife { get; } = 2370.0d;
        public override double atomicWeight { get; } = 129.91166d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5066960.0), new Tellurium130() } },

        };
    }
}
    
    
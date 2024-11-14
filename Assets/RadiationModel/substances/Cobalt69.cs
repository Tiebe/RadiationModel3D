using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt69 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt69";
        public override double halfLife { get; } = 0.18d;
        public override double atomicWeight { get; } = 68.9459d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9589000.0), new Nickel69() } },

        };
    }
}
    
    
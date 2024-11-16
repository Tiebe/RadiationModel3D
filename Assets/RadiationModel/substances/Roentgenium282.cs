using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium282 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium282";
        public override double halfLife { get; } = 130.0d;
        public override double atomicWeight { get; } = 282.16934d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10565047.4), new Meitnerium278() } },

        };
    }
}
    
    
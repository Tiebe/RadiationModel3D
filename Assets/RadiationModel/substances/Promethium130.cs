using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium130";
        public override double halfLife { get; } = 2.6d;
        public override double atomicWeight { get; } = 129.94045d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 11126000.0), new Neodymium130() } },

        };
    }
}
    
    
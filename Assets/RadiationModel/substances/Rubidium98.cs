using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium98";
        public override double halfLife { get; } = 0.115d;
        public override double atomicWeight { get; } = 97.94163d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12053000.0), new Strontium98() } },

        };
    }
}
    
    
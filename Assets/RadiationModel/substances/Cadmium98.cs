using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium98";
        public override double halfLife { get; } = 9.29d;
        public override double atomicWeight { get; } = 97.92739d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5430000.0), new Silver98() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver123m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver123m";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 122.92538d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7904200.0), new Cadmium123() } },

        };
    }
}
    
    
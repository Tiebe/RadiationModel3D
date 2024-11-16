using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium98m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium98m";
        public override double halfLife { get; } = 0.096d;
        public override double atomicWeight { get; } = 97.94171d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12126000.0), new Strontium98() } },

        };
    }
}
    
    
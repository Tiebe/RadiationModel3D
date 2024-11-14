using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur45 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur45";
        public override double halfLife { get; } = 0.068d;
        public override double atomicWeight { get; } = 44.99641d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 14920000.0), new Chlorine45() } },

        };
    }
}
    
    
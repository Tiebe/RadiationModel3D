using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium95";
        public override double halfLife { get; } = 0.032d;
        public override double atomicWeight { get; } = 94.94948d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 12850000.0), new Silver95() } },

        };
    }
}
    
    
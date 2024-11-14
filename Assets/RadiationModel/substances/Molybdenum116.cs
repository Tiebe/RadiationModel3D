using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum116 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum116";
        public override double halfLife { get; } = 0.032d;
        public override double atomicWeight { get; } = 115.95576d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10000000.0), new Technetium116() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum108 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum108";
        public override double halfLife { get; } = 1.105d;
        public override double atomicWeight { get; } = 107.92405d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5174000.0), new Technetium108() } },

        };
    }
}
    
    
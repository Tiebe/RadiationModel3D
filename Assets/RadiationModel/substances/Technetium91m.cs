
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium91m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium91m";
        public override double halfLife { get; } = 198.0d;
        public override double atomicWeight { get; } = 90.91857d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum91() } },

        };
    }
}
    
    
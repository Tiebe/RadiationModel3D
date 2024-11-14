using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium95m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium95m";
        public override double halfLife { get; } = 5353344.0d;
        public override double atomicWeight { get; } = 94.90769d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.961d, new List<RadioactiveSubstance> { new BetaParticle(1, 1729870.0), new Molybdenum95() } },
            { 0.039d, new List<RadioactiveSubstance> { new GammaParticle(0.03179), new Technetium95() } },

        };
    }
}
    
    
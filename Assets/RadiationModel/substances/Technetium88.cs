using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium88 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium88";
        public override double halfLife { get; } = 6.4d;
        public override double atomicWeight { get; } = 87.93379d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 11017000.0), new Molybdenum88() } },

        };
    }
}
    
    
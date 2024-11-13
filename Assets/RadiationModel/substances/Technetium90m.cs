
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium90m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium90m";
        public override double halfLife { get; } = 8.7d;
        public override double atomicWeight { get; } = 89.92423d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum90() } },

        };
    }
}
    
    
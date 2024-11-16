using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum111m : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum111m";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 110.93576d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9185000.0), new Technetium111() } },

        };
    }
}
    
    
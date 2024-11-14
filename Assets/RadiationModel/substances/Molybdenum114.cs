using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum114 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum114";
        public override double halfLife { get; } = 0.058d;
        public override double atomicWeight { get; } = 113.94667d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8920000.0), new Technetium114() } },

        };
    }
}
    
    
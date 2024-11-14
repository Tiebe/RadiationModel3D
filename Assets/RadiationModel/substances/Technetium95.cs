using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium95";
        public override double halfLife { get; } = 69328.8d;
        public override double atomicWeight { get; } = 94.90765d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1690870.0), new Molybdenum95() } },

        };
    }
}
    
    
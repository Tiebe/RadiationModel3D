using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium120";
        public override double halfLife { get; } = 0.021d;
        public override double atomicWeight { get; } = 119.96243d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 14720000.0), new Ruthenium120() } },

        };
    }
}
    
    
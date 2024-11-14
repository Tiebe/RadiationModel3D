using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium88m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium88m";
        public override double halfLife { get; } = 5.8d;
        public override double atomicWeight { get; } = 87.93387d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 11087000.0), new Molybdenum88() } },

        };
    }
}
    
    
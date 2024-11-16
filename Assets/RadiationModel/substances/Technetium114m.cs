using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium114m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium114m";
        public override double halfLife { get; } = 0.09d;
        public override double atomicWeight { get; } = 113.93727d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11784000.0), new Ruthenium114() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver114m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver114m";
        public override double halfLife { get; } = 0.0015d;
        public override double atomicWeight { get; } = 113.90904d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00623), new Silver114() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold192n : RadioactiveSubstance
    {
        public override string name { get; } = "Gold192n";
        public override double halfLife { get; } = 0.16d;
        public override double atomicWeight { get; } = 191.96528d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00287), new Gold192() } },

        };
    }
}
    
    
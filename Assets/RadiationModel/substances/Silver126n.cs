using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver126n : RadioactiveSubstance
    {
        public override string name { get; } = "Silver126n";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 125.93508d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00496), new Silver126() } },

        };
    }
}
    
    
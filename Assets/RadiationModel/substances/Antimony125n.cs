using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony125n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony125n";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 124.90752d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2112099.99999, 0.00059)), new Antimony125() } },

        };
    }
}
    
    
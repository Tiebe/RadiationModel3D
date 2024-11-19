using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead195n : RadioactiveSubstance
    {
        public override string name { get; } = "Lead195n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 194.9764d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0007, 1759000.0), new Lead195() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold195n : RadioactiveSubstance
    {
        public override string name { get; } = "Gold195n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 194.96772d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0005, 2501100.0), new Gold195() } },

        };
    }
}
    
    
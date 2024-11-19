using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium143n : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium143n";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 142.91763d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2793800.0, 0.00044)), new Samarium143() } },

        };
    }
}
    
    
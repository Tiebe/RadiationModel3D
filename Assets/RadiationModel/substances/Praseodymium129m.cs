using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium129m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium129m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 128.92551d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((384000.0, 0.00323)), new Praseodymium129() } },

        };
    }
}
    
    
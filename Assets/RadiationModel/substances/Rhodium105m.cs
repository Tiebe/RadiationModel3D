using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium105m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium105m";
        public override double halfLife { get; } = 42.8d;
        public override double atomicWeight { get; } = 104.90583d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((129700.0, 0.00956)), new Rhodium105() } },

        };
    }
}
    
    
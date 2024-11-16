using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury201m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury201m";
        public override double halfLife { get; } = 9e-05d;
        public override double atomicWeight { get; } = 200.97113d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((766199.99999, 0.00162)), new Mercury201() } },

        };
    }
}
    
    
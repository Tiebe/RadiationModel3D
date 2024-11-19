using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum181m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum181m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 180.94801d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((6199.99999, 0.19997)), new Tantalum181() } },

        };
    }
}
    
    
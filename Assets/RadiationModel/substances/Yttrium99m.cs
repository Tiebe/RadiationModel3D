using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium99m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium99m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 98.92646d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2142000.0, 0.00058)), new Yttrium99() } },

        };
    }
}
    
    
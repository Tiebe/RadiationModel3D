using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium138m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium138m";
        public override double halfLife { get; } = 0.00873d;
        public override double atomicWeight { get; } = 137.90828d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2129300.00001, 0.00058)), new Cerium138() } },

        };
    }
}
    
    
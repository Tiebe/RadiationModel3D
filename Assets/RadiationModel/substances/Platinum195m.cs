using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum195m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum195m";
        public override double halfLife { get; } = 346464.0d;
        public override double atomicWeight { get; } = 194.96507d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((259099.99999, 0.00479)), new Platinum195() } },

        };
    }
}
    
    
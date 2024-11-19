using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon133n : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon133n";
        public override double halfLife { get; } = 0.00864d;
        public override double atomicWeight { get; } = 132.90822d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2146599.99999, 0.00058)), new Xenon133() } },

        };
    }
}
    
    
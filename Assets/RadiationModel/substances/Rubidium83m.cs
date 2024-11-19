using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium83m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium83m";
        public override double halfLife { get; } = 0.0078d;
        public override double atomicWeight { get; } = 82.91516d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((42099.99999, 0.02945)), new Rubidium83() } },

        };
    }
}
    
    
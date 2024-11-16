using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium135m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium135m";
        public override double halfLife { get; } = 0.00011d;
        public override double atomicWeight { get; } = 134.9135d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((358000.0, 0.00346)), new Praseodymium135() } },

        };
    }
}
    
    
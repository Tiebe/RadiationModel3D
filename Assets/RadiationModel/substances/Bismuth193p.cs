using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth193p : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth193p";
        public override double halfLife { get; } = 9e-05d;
        public override double atomicWeight { get; } = 192.98547d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00053, 2350000.0), new Bismuth193() } },

        };
    }
}
    
    
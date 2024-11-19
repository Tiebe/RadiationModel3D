using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium194m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium194m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 193.99067d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00054, 2313000.0), new Polonium194() } },

        };
    }
}
    
    
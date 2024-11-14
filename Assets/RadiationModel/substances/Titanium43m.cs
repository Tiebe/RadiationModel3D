using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium43m : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium43m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 42.96886d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00396), new Titanium43() } },

        };
    }
}
    
    
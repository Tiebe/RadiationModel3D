using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium125m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium125m";
        public override double halfLife { get; } = 4959360.0d;
        public override double atomicWeight { get; } = 124.90459d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00856, 144800.0), new Tellurium125() } },

        };
    }
}
    
    
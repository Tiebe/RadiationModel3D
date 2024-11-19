using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon125m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon125m";
        public override double halfLife { get; } = 56.9d;
        public override double atomicWeight { get; } = 124.90666d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00491, 252600.0), new Xenon125() } },

        };
    }
}
    
    
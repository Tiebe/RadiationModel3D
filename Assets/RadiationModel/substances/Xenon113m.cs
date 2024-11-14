using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon113m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon113m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 112.93365d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00307), new Xenon113() } },

        };
    }
}
    
    
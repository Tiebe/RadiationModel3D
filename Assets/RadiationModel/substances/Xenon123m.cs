using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon123m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon123m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 122.90868d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0067, 185000.0), new Xenon123() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon133m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon133m";
        public override double halfLife { get; } = 189907.2d;
        public override double atomicWeight { get; } = 132.90616d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00532, 233200.0), new Xenon133() } },

        };
    }
}
    
    
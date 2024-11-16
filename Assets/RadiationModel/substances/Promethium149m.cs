using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium149m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium149m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 148.9186d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00516), new Promethium149() } },

        };
    }
}
    
    
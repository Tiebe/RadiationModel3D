using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth201n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth201n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 200.97911d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1973000.0, 0.00063)), new Bismuth201() } },

        };
    }
}
    
    
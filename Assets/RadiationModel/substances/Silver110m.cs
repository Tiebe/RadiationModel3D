using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver110m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver110m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 109.90611d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1099.99999, 1.12713)), new Silver110() } },

        };
    }
}
    
    
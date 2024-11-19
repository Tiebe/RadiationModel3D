using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth199p : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth199p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 198.98041d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2548000.0, 0.00049)), new Bismuth199() } },

        };
    }
}
    
    
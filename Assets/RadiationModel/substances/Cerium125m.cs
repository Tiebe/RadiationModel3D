using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium125m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium125m";
        public override double halfLife { get; } = 13.0d;
        public override double atomicWeight { get; } = 124.92853d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01378), new Cerium125() } },

        };
    }
}
    
    
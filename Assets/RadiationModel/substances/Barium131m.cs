using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium131m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium131m";
        public override double halfLife { get; } = 855.6d;
        public override double atomicWeight { get; } = 130.90715d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00659), new Barium131() } },

        };
    }
}
    
    
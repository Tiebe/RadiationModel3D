using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth206n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth206n";
        public override double halfLife { get; } = 0.00089d;
        public override double atomicWeight { get; } = 205.97962d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00119), new Bismuth206() } },

        };
    }
}
    
    
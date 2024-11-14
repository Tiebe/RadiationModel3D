using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium130m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium130m";
        public override double halfLife { get; } = 0.00954d;
        public override double atomicWeight { get; } = 129.90898d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0005), new Barium130() } },

        };
    }
}
    
    
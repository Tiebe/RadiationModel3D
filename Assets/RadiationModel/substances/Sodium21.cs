using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium21 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium21";
        public override double halfLife { get; } = 22.455d;
        public override double atomicWeight { get; } = 20.99765d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3546920.0), new Neon21() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin132 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin132";
        public override double halfLife { get; } = 39.7d;
        public override double atomicWeight { get; } = 131.91782d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3088700.0), new Antimony132() } },

        };
    }
}
    
    
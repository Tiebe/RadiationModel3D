using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium111";
        public override double halfLife { get; } = 26.2d;
        public override double atomicWeight { get; } = 110.921d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7250000.0), new Antimony111() } },

        };
    }
}
    
    
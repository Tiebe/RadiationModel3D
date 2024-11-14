using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon32 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon32";
        public override double halfLife { get; } = 0.0035d;
        public override double atomicWeight { get; } = 32.03972d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 18360000.0), new Sodium32() } },

        };
    }
}
    
    
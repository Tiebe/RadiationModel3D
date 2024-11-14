using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium20 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium20";
        public override double halfLife { get; } = 0.4479d;
        public override double atomicWeight { get; } = 20.00735d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 13892432.2), new Neon20() } },

        };
    }
}
    
    
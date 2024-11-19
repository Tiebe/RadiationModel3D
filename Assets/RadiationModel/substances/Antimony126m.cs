using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony126m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony126m";
        public override double halfLife { get; } = 1149.0d;
        public override double atomicWeight { get; } = 125.90728d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3694200.0), new Tellurium126() } },
            { 0.14d, new List<RadioactiveSubstance> { new GammaParticle((20000.0, 0.06199)), new Antimony126() } },

        };
    }
}
    
    
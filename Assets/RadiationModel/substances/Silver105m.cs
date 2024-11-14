using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver105m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver105m";
        public override double halfLife { get; } = 433.8d;
        public override double atomicWeight { get; } = 104.90655d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9965999999999999d, new List<RadioactiveSubstance> { new GammaParticle(0.04959), new Silver105() } },
            { 0.0034000000000000002d, new List<RadioactiveSubstance> { new BetaParticle(1, 1371900.0), new Palladium105() } },

        };
    }
}
    
    
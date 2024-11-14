using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin129m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin129m";
        public override double halfLife { get; } = 414.0d;
        public override double atomicWeight { get; } = 128.91352d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4073000.0), new Antimony129() } },

        };
    }
}
    
    
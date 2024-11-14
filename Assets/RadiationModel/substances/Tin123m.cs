using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin123m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin123m";
        public override double halfLife { get; } = 2403.6d;
        public override double atomicWeight { get; } = 122.90575d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1432800.0), new Antimony123() } },

        };
    }
}
    
    
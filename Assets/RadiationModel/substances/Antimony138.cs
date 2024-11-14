using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony138 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony138";
        public override double halfLife { get; } = 0.333d;
        public override double atomicWeight { get; } = 137.94133d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11046000.0), new Tellurium138() } },

        };
    }
}
    
    
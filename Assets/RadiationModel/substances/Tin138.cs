using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin138 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin138";
        public override double halfLife { get; } = 0.148d;
        public override double atomicWeight { get; } = 137.95114d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9140000.0), new Antimony138() } },

        };
    }
}
    
    
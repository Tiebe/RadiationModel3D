using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin136 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin136";
        public override double halfLife { get; } = 0.355d;
        public override double atomicWeight { get; } = 135.9397d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8337000.0), new Antimony136() } },

        };
    }
}
    
    
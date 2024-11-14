using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium251 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium251";
        public override double halfLife { get; } = 3336.0d;
        public override double atomicWeight { get; } = 251.08076d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1093000.0), new Californium251() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony142 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony142";
        public override double halfLife { get; } = 0.08d;
        public override double atomicWeight { get; } = 141.96392d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12940000.0), new Tellurium142() } },

        };
    }
}
    
    
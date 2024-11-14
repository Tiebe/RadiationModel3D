using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron68 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron68";
        public override double halfLife { get; } = 0.188d;
        public override double atomicWeight { get; } = 67.95287d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7743000.0), new Cobalt68() } },

        };
    }
}
    
    
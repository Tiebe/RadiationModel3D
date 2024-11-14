using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium171";
        public override double halfLife { get; } = 1.23d;
        public override double atomicWeight { get; } = 170.95301d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6240000.0), new Dysprosium171() } },

        };
    }
}
    
    
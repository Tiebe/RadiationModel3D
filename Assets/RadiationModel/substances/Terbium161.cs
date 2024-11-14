using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium161";
        public override double halfLife { get; } = 600307.2d;
        public override double atomicWeight { get; } = 160.92758d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 593700.0), new Dysprosium161() } },

        };
    }
}
    
    
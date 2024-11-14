using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon24 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon24";
        public override double halfLife { get; } = 202.8d;
        public override double atomicWeight { get; } = 23.99361d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2466301.0), new Sodium24() } },
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1994094.0), new Sodium24m() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium158";
        public override double halfLife { get; } = 5680251360.0d;
        public override double atomicWeight { get; } = 157.92542d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8340000000000001d, new List<RadioactiveSubstance> { new BetaParticle(1, 1219100.0), new Gadolinium158() } },
            { 0.166d, new List<RadioactiveSubstance> { new BetaParticle(-1, 936300.0), new Dysprosium158() } },

        };
    }
}
    
    
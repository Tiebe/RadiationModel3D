using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium166";
        public override double halfLife { get; } = 27.1d;
        public override double atomicWeight { get; } = 165.93794d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4775700.0), new Dysprosium166() } },

        };
    }
}
    
    
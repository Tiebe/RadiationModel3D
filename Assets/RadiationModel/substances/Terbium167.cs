using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium167";
        public override double halfLife { get; } = 18.9d;
        public override double atomicWeight { get; } = 166.94001d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4027900.0), new Dysprosium167() } },

        };
    }
}
    
    
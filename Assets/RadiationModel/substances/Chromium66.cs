using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium66 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium66";
        public override double halfLife { get; } = 0.0238d;
        public override double atomicWeight { get; } = 65.97301d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11610000.0), new Manganese66() } },

        };
    }
}
    
    
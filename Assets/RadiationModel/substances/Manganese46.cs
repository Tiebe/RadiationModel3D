using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese46 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese46";
        public override double halfLife { get; } = 0.0362d;
        public override double atomicWeight { get; } = 45.98667d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 17052000.0), new Chromium46() } },

        };
    }
}
    
    
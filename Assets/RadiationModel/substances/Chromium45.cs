using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium45 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium45";
        public override double halfLife { get; } = 0.0609d;
        public override double atomicWeight { get; } = 44.97906d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 12376400.0), new Vanadium45() } },

        };
    }
}
    
    
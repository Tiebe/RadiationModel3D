using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium46 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium46";
        public override double halfLife { get; } = 0.2243d;
        public override double atomicWeight { get; } = 45.96836d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7603900.0), new Vanadium46() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium47 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium47";
        public override double halfLife { get; } = 0.4616d;
        public override double atomicWeight { get; } = 46.9629d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7444070.0), new Vanadium47() } },

        };
    }
}
    
    
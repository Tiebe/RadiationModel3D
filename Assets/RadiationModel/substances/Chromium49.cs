using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium49 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium49";
        public override double halfLife { get; } = 2538.0d;
        public override double atomicWeight { get; } = 48.95133d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2629800.0), new Vanadium49() } },

        };
    }
}
    
    
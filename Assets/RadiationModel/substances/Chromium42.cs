using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium42 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium42";
        public override double halfLife { get; } = 0.0133d;
        public override double atomicWeight { get; } = 42.00758d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 14680000.0), new Vanadium42() } },

        };
    }
}
    
    
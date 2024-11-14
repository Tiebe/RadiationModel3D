using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium63 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium63";
        public override double halfLife { get; } = 0.0196d;
        public override double atomicWeight { get; } = 62.97666d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 14440000.0), new Chromium63() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium61 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium61";
        public override double halfLife { get; } = 0.243d;
        public override double atomicWeight { get; } = 60.95438d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9245600.0), new Manganese61() } },

        };
    }
}
    
    
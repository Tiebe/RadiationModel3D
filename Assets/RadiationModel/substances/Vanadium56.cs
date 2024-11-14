using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium56 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium56";
        public override double halfLife { get; } = 0.216d;
        public override double atomicWeight { get; } = 55.95042d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9105100.0), new Chromium56() } },

        };
    }
}
    
    
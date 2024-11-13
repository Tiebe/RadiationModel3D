
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium57 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium57";
        public override double halfLife { get; } = 0.35d;
        public override double atomicWeight { get; } = 56.95229d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chromium57() } },

        };
    }
}
    
    
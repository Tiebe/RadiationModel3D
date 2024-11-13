
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium57 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium57";
        public override double halfLife { get; } = 21.1d;
        public override double atomicWeight { get; } = 56.94361d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Manganese57() } },

        };
    }
}
    
    
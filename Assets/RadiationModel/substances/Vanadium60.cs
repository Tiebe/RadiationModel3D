using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium60 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium60";
        public override double halfLife { get; } = 0.122d;
        public override double atomicWeight { get; } = 59.96448d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 13818500.0), new Chromium60() } },

        };
    }
}
    
    
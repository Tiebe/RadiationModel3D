using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium60 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium60";
        public override double halfLife { get; } = 0.49d;
        public override double atomicWeight { get; } = 59.94964d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6059400.0), new Manganese60() } },

        };
    }
}
    
    
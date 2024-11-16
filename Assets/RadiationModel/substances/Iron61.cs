using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron61 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron61";
        public override double halfLife { get; } = 358.8d;
        public override double atomicWeight { get; } = 60.93675d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3977700.0), new Cobalt61() } },

        };
    }
}
    
    
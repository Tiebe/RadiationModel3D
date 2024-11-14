using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron47 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron47";
        public override double halfLife { get; } = 0.0219d;
        public override double atomicWeight { get; } = 46.99235d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 15440000.0), new Manganese47() } },

        };
    }
}
    
    
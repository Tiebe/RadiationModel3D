using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron53 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron53";
        public override double halfLife { get; } = 510.6d;
        public override double atomicWeight { get; } = 52.94531d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3742800.0), new Manganese53() } },

        };
    }
}
    
    
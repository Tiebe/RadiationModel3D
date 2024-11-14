using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron50 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron50";
        public override double halfLife { get; } = 0.152d;
        public override double atomicWeight { get; } = 49.96299d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8150890.0), new Manganese50() } },

        };
    }
}
    
    
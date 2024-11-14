using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron51 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron51";
        public override double halfLife { get; } = 0.3054d;
        public override double atomicWeight { get; } = 50.95686d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8054000.0), new Manganese51() } },

        };
    }
}
    
    
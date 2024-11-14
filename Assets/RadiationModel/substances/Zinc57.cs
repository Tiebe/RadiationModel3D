using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc57 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc57";
        public override double halfLife { get; } = 0.0457d;
        public override double atomicWeight { get; } = 56.96506d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 14759000.0), new Copper57() } },

        };
    }
}
    
    
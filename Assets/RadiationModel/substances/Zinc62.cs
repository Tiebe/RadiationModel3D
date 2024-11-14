using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc62 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc62";
        public override double halfLife { get; } = 33094.8d;
        public override double atomicWeight { get; } = 61.93433d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1619400.0), new Copper62() } },

        };
    }
}
    
    
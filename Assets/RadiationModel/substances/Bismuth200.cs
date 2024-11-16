using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth200 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth200";
        public override double halfLife { get; } = 2184.0d;
        public override double atomicWeight { get; } = 199.97813d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5880000.0), new Lead200() } },

        };
    }
}
    
    
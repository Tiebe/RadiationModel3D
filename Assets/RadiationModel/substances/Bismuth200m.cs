
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth200m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth200m";
        public override double halfLife { get; } = 1860.0d;
        public override double atomicWeight { get; } = 199.97824d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lead200() } },

        };
    }
}
    
    
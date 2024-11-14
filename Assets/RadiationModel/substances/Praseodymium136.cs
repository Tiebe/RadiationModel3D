using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium136 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium136";
        public override double halfLife { get; } = 786.0d;
        public override double atomicWeight { get; } = 135.91268d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5168500.0), new Cerium136() } },

        };
    }
}
    
    
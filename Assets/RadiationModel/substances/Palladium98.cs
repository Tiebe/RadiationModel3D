using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium98";
        public override double halfLife { get; } = 1062.0d;
        public override double atomicWeight { get; } = 97.9127d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1854000.0), new Rhodium98() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver98 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver98";
        public override double halfLife { get; } = 47.5d;
        public override double atomicWeight { get; } = 97.92156d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8251000.0), new Palladium98() } },

        };
    }
}
    
    
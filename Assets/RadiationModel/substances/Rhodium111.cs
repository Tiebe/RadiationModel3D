using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium111";
        public override double halfLife { get; } = 11.0d;
        public override double atomicWeight { get; } = 110.91164d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3681900.0), new Palladium111() } },

        };
    }
}
    
    
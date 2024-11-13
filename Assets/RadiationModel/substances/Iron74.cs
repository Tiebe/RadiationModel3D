
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron74 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron74";
        public override double halfLife { get; } = 0.005d;
        public override double atomicWeight { get; } = 73.97782d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cobalt74() } },

        };
    }
}
    
    
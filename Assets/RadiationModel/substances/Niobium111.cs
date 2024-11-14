using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium111";
        public override double halfLife { get; } = 0.054d;
        public override double atomicWeight { get; } = 110.94744d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10980000.0), new Molybdenum111() } },

        };
    }
}
    
    
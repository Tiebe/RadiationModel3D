using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt70 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt70";
        public override double halfLife { get; } = 0.508d;
        public override double atomicWeight { get; } = 69.95005d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12688900.0), new Nickel70() } },

        };
    }
}
    
    
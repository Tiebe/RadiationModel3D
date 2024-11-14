using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt70m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt70m";
        public override double halfLife { get; } = 0.112d;
        public override double atomicWeight { get; } = 69.95026d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12883900.0), new Nickel70() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt63 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt63";
        public override double halfLife { get; } = 26.9d;
        public override double atomicWeight { get; } = 62.9336d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3660900.0), new Nickel63() } },

        };
    }
}
    
    
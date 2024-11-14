using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton71 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton71";
        public override double halfLife { get; } = 0.0988d;
        public override double atomicWeight { get; } = 70.95026d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10172000.0), new Bromine71() } },

        };
    }
}
    
    
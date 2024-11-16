using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt71 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt71";
        public override double halfLife { get; } = 0.08d;
        public override double atomicWeight { get; } = 70.95237d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11036200.0), new Nickel71() } },

        };
    }
}
    
    
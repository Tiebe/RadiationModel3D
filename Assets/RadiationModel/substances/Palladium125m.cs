using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium125m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium125m";
        public override double halfLife { get; } = 0.05d;
        public override double atomicWeight { get; } = 124.94218d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10660000.0), new Silver125() } },

        };
    }
}
    
    
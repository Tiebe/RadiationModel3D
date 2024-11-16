using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium114";
        public override double halfLife { get; } = 145.2d;
        public override double atomicWeight { get; } = 113.91037d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1441000.0), new Silver114() } },

        };
    }
}
    
    
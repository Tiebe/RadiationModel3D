using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium117";
        public override double halfLife { get; } = 4.3d;
        public override double atomicWeight { get; } = 116.91796d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5758000.0), new Silver117() } },

        };
    }
}
    
    
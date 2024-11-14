using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum134 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum134";
        public override double halfLife { get; } = 387.0d;
        public override double atomicWeight { get; } = 133.90851d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3731000.0), new Barium134() } },

        };
    }
}
    
    
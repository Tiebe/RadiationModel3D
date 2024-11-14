using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium134 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium134";
        public override double halfLife { get; } = 510.0d;
        public override double atomicWeight { get; } = 133.91879d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2882000.0), new Praseodymium134() } },

        };
    }
}
    
    
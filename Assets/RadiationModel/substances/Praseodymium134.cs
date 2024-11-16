using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium134 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium134";
        public override double halfLife { get; } = 1020.0d;
        public override double atomicWeight { get; } = 133.9157d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6305000.0), new Cerium134() } },

        };
    }
}
    
    
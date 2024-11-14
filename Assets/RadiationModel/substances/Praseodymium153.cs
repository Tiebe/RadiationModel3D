using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium153";
        public override double halfLife { get; } = 4.28d;
        public override double atomicWeight { get; } = 152.9339d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5762400.0), new Neodymium153() } },

        };
    }
}
    
    
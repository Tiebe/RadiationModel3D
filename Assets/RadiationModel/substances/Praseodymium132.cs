using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium132";
        public override double halfLife { get; } = 89.4d;
        public override double atomicWeight { get; } = 131.91924d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7242000.0), new Cerium132() } },

        };
    }
}
    
    
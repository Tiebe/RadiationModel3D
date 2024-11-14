using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium132";
        public override double halfLife { get; } = 93.6d;
        public override double atomicWeight { get; } = 131.92332d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3801000.0), new Praseodymium132() } },

        };
    }
}
    
    
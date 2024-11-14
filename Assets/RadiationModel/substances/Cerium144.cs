using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium144";
        public override double halfLife { get; } = 24614150.4d;
        public override double atomicWeight { get; } = 143.91365d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 318700.0), new Praseodymium144() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium144";
        public override double halfLife { get; } = 1036.8d;
        public override double atomicWeight { get; } = 143.91331d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2997400.0), new Neodymium144() } },

        };
    }
}
    
    
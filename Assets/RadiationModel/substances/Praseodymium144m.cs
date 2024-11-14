using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium144m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium144m";
        public override double halfLife { get; } = 432.0d;
        public override double atomicWeight { get; } = 143.91337d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.02101), new Praseodymium144() } },
            { 0.0007000000000000001d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3056400.0), new Neodymium144() } },

        };
    }
}
    
    
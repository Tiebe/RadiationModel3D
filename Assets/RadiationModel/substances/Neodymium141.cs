using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium141";
        public override double halfLife { get; } = 8964.0d;
        public override double atomicWeight { get; } = 140.90962d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1822500.0), new Praseodymium141() } },
            { 0.9728d, new List<RadioactiveSubstance> { new Praseodymium141() } },
            { 0.027200000000000002d, new List<RadioactiveSubstance> { new BetaParticle(1, 1822500.0), new Praseodymium141() } },

        };
    }
}
    
    
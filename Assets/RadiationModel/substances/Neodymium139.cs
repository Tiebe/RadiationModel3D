using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium139";
        public override double halfLife { get; } = 1782.0d;
        public override double atomicWeight { get; } = 138.91195d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2812000.0), new Praseodymium139() } },

        };
    }
}
    
    
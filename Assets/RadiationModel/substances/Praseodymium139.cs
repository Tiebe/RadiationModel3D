using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium139";
        public override double halfLife { get; } = 15876.0d;
        public override double atomicWeight { get; } = 138.90893d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2128700.0), new Cerium139() } },

        };
    }
}
    
    
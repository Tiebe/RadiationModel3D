using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium277 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium277";
        public override double halfLife { get; } = 0.00079d;
        public override double atomicWeight { get; } = 277.16353d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(12637002.09), new Darmstadtium273() } },

        };
    }
}
    
    
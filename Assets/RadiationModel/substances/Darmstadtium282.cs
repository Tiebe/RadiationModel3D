using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium282 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium282";
        public override double halfLife { get; } = 252.0d;
        public override double atomicWeight { get; } = 282.16617d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10167002.09), new Hassium278() } },

        };
    }
}
    
    
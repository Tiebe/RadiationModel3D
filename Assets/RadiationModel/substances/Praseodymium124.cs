using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium124 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium124";
        public override double halfLife { get; } = 1.2d;
        public override double atomicWeight { get; } = 123.94294d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 11770000.0), new Cerium124() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper79 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper79";
        public override double halfLife { get; } = 0.2413d;
        public override double atomicWeight { get; } = 78.95447d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11022300.0), new Zinc79() } },

        };
    }
}
    
    
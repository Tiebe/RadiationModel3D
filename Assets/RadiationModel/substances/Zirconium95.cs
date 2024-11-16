using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium95";
        public override double halfLife { get; } = 5532364.8d;
        public override double atomicWeight { get; } = 94.90804d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1126400.0), new Niobium95() } },

        };
    }
}
    
    
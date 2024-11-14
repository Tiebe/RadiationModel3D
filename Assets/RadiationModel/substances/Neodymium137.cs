using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium137";
        public override double halfLife { get; } = 2310.0d;
        public override double atomicWeight { get; } = 136.91456d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3618000.0), new Praseodymium137() } },

        };
    }
}
    
    
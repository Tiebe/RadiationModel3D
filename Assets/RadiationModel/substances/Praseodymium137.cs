using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium137";
        public override double halfLife { get; } = 4608.0d;
        public override double atomicWeight { get; } = 136.91068d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2716800.0), new Cerium137() } },

        };
    }
}
    
    
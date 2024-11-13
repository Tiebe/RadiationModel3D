
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium158";
        public override double halfLife { get; } = 0.181d;
        public override double atomicWeight { get; } = 157.9526d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium158() } },

        };
    }
}
    
    
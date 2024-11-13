
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium143";
        public override double halfLife { get; } = 1172448.0d;
        public override double atomicWeight { get; } = 142.91082d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium143() } },

        };
    }
}
    
    
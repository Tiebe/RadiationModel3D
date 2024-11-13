
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium133";
        public override double halfLife { get; } = 390.0d;
        public override double atomicWeight { get; } = 132.91633d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium133() } },

        };
    }
}
    
    
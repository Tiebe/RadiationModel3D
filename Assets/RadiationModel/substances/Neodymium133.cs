
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium133";
        public override double halfLife { get; } = 70.0d;
        public override double atomicWeight { get; } = 132.92235d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium133() } },

        };
    }
}
    
    
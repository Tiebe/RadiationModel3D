
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium133m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium133m";
        public override double halfLife { get; } = 1.1d;
        public override double atomicWeight { get; } = 132.91654d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Praseodymium133() } },

        };
    }
}
    
    
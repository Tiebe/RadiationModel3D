using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium149";
        public override double halfLife { get; } = 135.6d;
        public override double atomicWeight { get; } = 148.92374d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3336500.0), new Neodymium149() } },

        };
    }
}
    
    
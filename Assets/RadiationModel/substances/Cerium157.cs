using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium157";
        public override double halfLife { get; } = 0.175d;
        public override double atomicWeight { get; } = 156.95713d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8505000.0), new Praseodymium157() } },

        };
    }
}
    
    
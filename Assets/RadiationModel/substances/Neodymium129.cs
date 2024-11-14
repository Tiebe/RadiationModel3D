using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium129 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium129";
        public override double halfLife { get; } = 6.8d;
        public override double atomicWeight { get; } = 128.93303d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7394000.0), new Praseodymium129() } },

        };
    }
}
    
    
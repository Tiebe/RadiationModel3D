using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium153";
        public override double halfLife { get; } = 0.865d;
        public override double atomicWeight { get; } = 152.94105d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6658000.0), new Praseodymium153() } },

        };
    }
}
    
    
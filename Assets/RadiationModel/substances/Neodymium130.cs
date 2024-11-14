using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium130";
        public override double halfLife { get; } = 21.0d;
        public override double atomicWeight { get; } = 129.92851d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4584000.0), new Praseodymium130() } },

        };
    }
}
    
    
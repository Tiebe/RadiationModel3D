using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium130";
        public override double halfLife { get; } = 40.0d;
        public override double atomicWeight { get; } = 129.92359d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8243000.0), new Cerium130() } },

        };
    }
}
    
    
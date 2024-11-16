using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton74 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton74";
        public override double halfLife { get; } = 690.0d;
        public override double atomicWeight { get; } = 73.93308d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2956200.0), new Bromine74() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine23 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine23";
        public override double halfLife { get; } = 2.23d;
        public override double atomicWeight { get; } = 23.00353d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8444050.0), new Neon23() } },

        };
    }
}
    
    
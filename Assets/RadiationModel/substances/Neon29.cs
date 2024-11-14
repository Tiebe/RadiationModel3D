using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon29 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon29";
        public override double halfLife { get; } = 0.0147d;
        public override double atomicWeight { get; } = 29.01975d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 15720000.0), new Sodium29() } },

        };
    }
}
    
    
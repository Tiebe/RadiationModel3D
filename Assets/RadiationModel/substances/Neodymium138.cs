using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium138";
        public override double halfLife { get; } = 18144.0d;
        public override double atomicWeight { get; } = 137.91195d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1112000.0), new Praseodymium138() } },

        };
    }
}
    
    
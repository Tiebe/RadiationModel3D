
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium138";
        public override double halfLife { get; } = 87.0d;
        public override double atomicWeight { get; } = 137.91076d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium138() } },

        };
    }
}
    
    
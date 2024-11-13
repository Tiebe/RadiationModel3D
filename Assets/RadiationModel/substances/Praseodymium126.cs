
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium126 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium126";
        public override double halfLife { get; } = 3.12d;
        public override double atomicWeight { get; } = 125.93524d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium126() } },

        };
    }
}
    
    
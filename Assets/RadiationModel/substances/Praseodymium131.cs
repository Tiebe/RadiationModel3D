
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium131";
        public override double halfLife { get; } = 90.0d;
        public override double atomicWeight { get; } = 130.92024d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium131() } },

        };
    }
}
    
    
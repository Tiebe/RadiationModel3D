
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium131";
        public override double halfLife { get; } = 25.4d;
        public override double atomicWeight { get; } = 130.92725d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium131() } },

        };
    }
}
    
    
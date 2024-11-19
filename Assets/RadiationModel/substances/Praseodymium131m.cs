using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium131m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium131m";
        public override double halfLife { get; } = 5.73d;
        public override double atomicWeight { get; } = 130.9204d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9640000000000001d, new List<RadioactiveSubstance> { new GammaParticle((150000.0, 0.00827)), new Praseodymium131() } },
            { 0.036000000000000004d, new List<RadioactiveSubstance> { new BetaParticle(1, 5560000.0), new Cerium131() } },

        };
    }
}
    
    
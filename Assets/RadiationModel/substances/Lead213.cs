using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead213 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead213";
        public override double halfLife { get; } = 612.0d;
        public override double atomicWeight { get; } = 212.99656d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2028000.0), new Bismuth213() } },

        };
    }
}
    
    
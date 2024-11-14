using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine74 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine74";
        public override double halfLife { get; } = 1524.0d;
        public override double atomicWeight { get; } = 73.92991d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6925210.0), new Selenium74() } },

        };
    }
}
    
    
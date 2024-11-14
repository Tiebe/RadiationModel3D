using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine76m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine76m";
        public override double halfLife { get; } = 1.31d;
        public override double atomicWeight { get; } = 75.92465d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01204), new Bromine76() } },
            { 0.006d, new List<RadioactiveSubstance> { new BetaParticle(1, 5065959.0), new Selenium76() } },

        };
    }
}
    
    
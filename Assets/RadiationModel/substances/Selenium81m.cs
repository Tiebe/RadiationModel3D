using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium81m : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium81m";
        public override double halfLife { get; } = 3436.8d;
        public override double atomicWeight { get; } = 80.9181d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((103000.0, 0.01204)), new Selenium81() } },
            { 0.0005099999999999999d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1691100.0), new Bromine81() } },

        };
    }
}
    
    
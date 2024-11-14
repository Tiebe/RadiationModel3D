using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine70m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine70m";
        public override double halfLife { get; } = 2.16d;
        public override double atomicWeight { get; } = 69.94725d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 12795900.0), new Selenium70() } },

        };
    }
}
    
    
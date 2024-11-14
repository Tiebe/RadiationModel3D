using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium71 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium71";
        public override double halfLife { get; } = 284.4d;
        public override double atomicWeight { get; } = 70.93221d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4746500.0), new Arsenic71() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium165m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium165m";
        public override double halfLife { get; } = 75.42d;
        public override double atomicWeight { get; } = 164.93183d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9776d, new List<RadioactiveSubstance> { new GammaParticle((108200.00002, 0.01146)), new Dysprosium165() } },
            { 0.022400000000000003d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1393900.0), new Holmium165() } },

        };
    }
}
    
    
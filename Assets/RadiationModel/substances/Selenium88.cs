using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium88 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium88";
        public override double halfLife { get; } = 1.53d;
        public override double atomicWeight { get; } = 87.93142d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6832000.0), new Bromine88() } },

        };
    }
}
    
    
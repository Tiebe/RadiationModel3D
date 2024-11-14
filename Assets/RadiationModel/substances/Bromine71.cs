using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine71 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine71";
        public override double halfLife { get; } = 21.4d;
        public override double atomicWeight { get; } = 70.93934d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6644500.0), new Selenium71() } },

        };
    }
}
    
    
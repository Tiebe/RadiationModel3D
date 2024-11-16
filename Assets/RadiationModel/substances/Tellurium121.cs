using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium121";
        public override double halfLife { get; } = 1668384.0d;
        public override double atomicWeight { get; } = 120.90495d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1056200.0), new Antimony121() } },

        };
    }
}
    
    
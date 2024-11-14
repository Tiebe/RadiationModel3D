using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium116";
        public override double halfLife { get; } = 8964.0d;
        public override double atomicWeight { get; } = 115.90847d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1558000.0), new Antimony116() } },

        };
    }
}
    
    
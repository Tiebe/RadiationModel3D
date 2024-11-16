using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium47 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium47";
        public override double halfLife { get; } = 289370.88d;
        public override double atomicWeight { get; } = 46.9524d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 600810.0), new Titanium47() } },

        };
    }
}
    
    
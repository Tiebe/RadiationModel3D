using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium151";
        public override double halfLife { get; } = 35.2d;
        public override double atomicWeight { get; } = 150.9317d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.88d, new List<RadioactiveSubstance> { new BetaParticle(1, 5129000.0), new Dysprosium151() } },
            { 0.22d, new List<RadioactiveSubstance> { new AlphaParticle(5717002.09), new Terbium147() } },

        };
    }
}
    
    
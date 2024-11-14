using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese50m : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese50m";
        public override double halfLife { get; } = 105.0d;
        public override double atomicWeight { get; } = 49.95448d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7859790.0), new Chromium50() } },

        };
    }
}
    
    
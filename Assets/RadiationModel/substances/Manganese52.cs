using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese52 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese52";
        public override double halfLife { get; } = 483062.4d;
        public override double atomicWeight { get; } = 51.94556d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4708120.0), new Chromium52() } },

        };
    }
}
    
    
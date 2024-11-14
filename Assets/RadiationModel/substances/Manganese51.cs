using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese51 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese51";
        public override double halfLife { get; } = 2748.6d;
        public override double atomicWeight { get; } = 50.94821d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3207510.0), new Chromium51() } },

        };
    }
}
    
    
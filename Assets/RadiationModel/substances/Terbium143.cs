using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium143";
        public override double halfLife { get; } = 12.0d;
        public override double atomicWeight { get; } = 142.93514d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7810000.0), new Gadolinium143() } },

        };
    }
}
    
    
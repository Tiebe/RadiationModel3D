using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium143";
        public override double halfLife { get; } = 5.6d;
        public override double atomicWeight { get; } = 142.94399d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8251000.0), new Terbium143() } },

        };
    }
}
    
    
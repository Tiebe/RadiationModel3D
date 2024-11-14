using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium165";
        public override double halfLife { get; } = 126.6d;
        public override double atomicWeight { get; } = 164.93496d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3023500.0), new Dysprosium165() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc61 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc61";
        public override double halfLife { get; } = 89.1d;
        public override double atomicWeight { get; } = 60.93951d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5635100.0), new Copper61() } },

        };
    }
}
    
    
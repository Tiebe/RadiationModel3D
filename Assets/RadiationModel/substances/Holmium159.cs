using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium159";
        public override double halfLife { get; } = 1983.0d;
        public override double atomicWeight { get; } = 158.92772d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1837200.0), new Dysprosium159() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury209 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury209";
        public override double halfLife { get; } = 6.3d;
        public override double atomicWeight { get; } = 208.99076d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5035000.0), new Thallium209() } },

        };
    }
}
    
    
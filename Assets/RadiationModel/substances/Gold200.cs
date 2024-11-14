using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold200 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold200";
        public override double halfLife { get; } = 2904.0d;
        public override double atomicWeight { get; } = 199.97076d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2263300.0), new Mercury200() } },

        };
    }
}
    
    
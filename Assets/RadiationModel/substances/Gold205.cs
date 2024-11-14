using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold205 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold205";
        public override double halfLife { get; } = 32.0d;
        public override double atomicWeight { get; } = 204.98006d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3718000.0), new Mercury205() } },

        };
    }
}
    
    
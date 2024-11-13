
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold185m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold185m";
        public override double halfLife { get; } = 408.0d;
        public override double atomicWeight { get; } = 184.96585d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Platinum185() } },

        };
    }
}
    
    
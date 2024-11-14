using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold194 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold194";
        public override double halfLife { get; } = 136872.0d;
        public override double atomicWeight { get; } = 193.96542d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2548200.0), new Platinum194() } },

        };
    }
}
    
    
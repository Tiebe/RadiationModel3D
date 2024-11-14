using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold182 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold182";
        public override double halfLife { get; } = 15.5d;
        public override double atomicWeight { get; } = 181.96961d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7864000.0), new Platinum182() } },
            { 0.0013d, new List<RadioactiveSubstance> { new AlphaParticle(6545047.4), new Iridium178() } },

        };
    }
}
    
    
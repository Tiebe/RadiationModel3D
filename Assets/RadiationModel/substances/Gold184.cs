using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold184 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold184";
        public override double halfLife { get; } = 20.6d;
        public override double atomicWeight { get; } = 183.96745d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7013000.0), new Platinum184() } },
            { 0.00013d, new List<RadioactiveSubstance> { new AlphaParticle(6254047.4), new Iridium180() } },

        };
    }
}
    
    
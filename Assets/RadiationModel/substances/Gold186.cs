using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold186 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold186";
        public override double halfLife { get; } = 642.0d;
        public override double atomicWeight { get; } = 185.96595d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6149000.0), new Platinum186() } },
            { 8e-06d, new List<RadioactiveSubstance> { new AlphaParticle(5934002.09), new Iridium182() } },

        };
    }
}
    
    
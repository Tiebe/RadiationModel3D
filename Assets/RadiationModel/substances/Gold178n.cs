using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold178n : RadioactiveSubstance
    {
        public override string name { get; } = "Gold178n";
        public override double halfLife { get; } = 2.7d;
        public override double atomicWeight { get; } = 177.97626d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.82d, new List<RadioactiveSubstance> { new BetaParticle(1, 9880000.0), new Platinum178() } },
            { 0.18d, new List<RadioactiveSubstance> { new AlphaParticle(7266002.09), new Iridium174() } },

        };
    }
}
    
    
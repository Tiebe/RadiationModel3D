using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold189 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold189";
        public override double halfLife { get; } = 1722.0d;
        public override double atomicWeight { get; } = 188.96395d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2887000.0), new Platinum189() } },
            { 3e-07d, new List<RadioactiveSubstance> { new AlphaParticle(5351002.09), new Iridium185() } },

        };
    }
}
    
    
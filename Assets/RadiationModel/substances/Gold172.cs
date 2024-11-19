using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold172 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold172";
        public override double halfLife { get; } = 0.028d;
        public override double atomicWeight { get; } = 171.98999d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7947002.09), new Iridium168() } },

        };
    }
}
    
    
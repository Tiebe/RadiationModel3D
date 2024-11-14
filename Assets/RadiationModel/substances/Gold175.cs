using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold175 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold175";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 174.98132d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.88d, new List<RadioactiveSubstance> { new AlphaParticle(7605047.4), new Iridium171() } },

        };
    }
}
    
    
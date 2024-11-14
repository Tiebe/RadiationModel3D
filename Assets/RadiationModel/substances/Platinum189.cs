using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum189 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum189";
        public override double halfLife { get; } = 39132.0d;
        public override double atomicWeight { get; } = 188.96085d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1981000.0), new Iridium189() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium167";
        public override double halfLife { get; } = 3090.0d;
        public override double atomicWeight { get; } = 166.93824d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3060000.0), new Ytterbium167() } },

        };
    }
}
    
    
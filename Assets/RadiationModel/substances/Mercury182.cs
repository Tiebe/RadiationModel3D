using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury182 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury182";
        public override double halfLife { get; } = 10.83d;
        public override double atomicWeight { get; } = 181.97469d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.862d, new List<RadioactiveSubstance> { new BetaParticle(1, 4727000.0), new Gold182() } },
            { 0.138d, new List<RadioactiveSubstance> { new AlphaParticle(7015047.4), new Platinum178() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury183 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury183";
        public override double halfLife { get; } = 9.4d;
        public override double atomicWeight { get; } = 182.97444d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.883d, new List<RadioactiveSubstance> { new BetaParticle(1, 6386000.0), new Gold183() } },
            { 0.11699999999999999d, new List<RadioactiveSubstance> { new AlphaParticle(7060002.09), new Platinum179() } },

        };
    }
}
    
    
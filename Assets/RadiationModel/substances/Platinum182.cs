using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum182 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum182";
        public override double halfLife { get; } = 160.2d;
        public override double atomicWeight { get; } = 181.96117d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.00962d, new List<RadioactiveSubstance> { new BetaParticle(1, 2884000.0), new Iridium182() } },
            { 0.00037999999999999997d, new List<RadioactiveSubstance> { new AlphaParticle(5973002.09), new Osmium178() } },

        };
    }
}
    
    
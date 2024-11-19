using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum179 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum179";
        public override double halfLife { get; } = 21.2d;
        public override double atomicWeight { get; } = 178.96536d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5814000.0), new Iridium179() } },
            { 0.0024d, new List<RadioactiveSubstance> { new AlphaParticle(6434002.09), new Osmium175() } },

        };
    }
}
    
    
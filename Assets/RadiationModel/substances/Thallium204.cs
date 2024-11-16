using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium204 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium204";
        public override double halfLife { get; } = 119379949.416d;
        public override double atomicWeight { get; } = 203.97386d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9708d, new List<RadioactiveSubstance> { new BetaParticle(-1, 763700.0), new Lead204() } },
            { 0.0292d, new List<RadioactiveSubstance> { new BetaParticle(1, -3700100.0), new Bismuth204() } },

        };
    }
}
    
    
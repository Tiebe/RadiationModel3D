
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

            { 0.9708d, new List<RadioactiveSubstance> { new BetaParticle(), new Lead204() } },

            { 0.0292d, new List<RadioactiveSubstance> { new BetaParticle(), new Bismuth204() } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium166";
        public override double halfLife { get; } = 0.213d;
        public override double atomicWeight { get; } = 165.9727d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.83d, new List<RadioactiveSubstance> { new AlphaParticle(7164002.09), new Tungsten162() } },
            { 0.17d, new List<RadioactiveSubstance> { new BetaParticle(1, 6408000.0), new Rhenium166() } },

        };
    }
}
    
    
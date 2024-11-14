using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine110 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine110";
        public override double halfLife { get; } = 0.664d;
        public override double atomicWeight { get; } = 109.93508d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.83d, new List<RadioactiveSubstance> { new BetaParticle(1, 11760000.0), new Tellurium110() } },
            { 0.17d, new List<RadioactiveSubstance> { new AlphaParticle(4598047.4), new Antimony106() } },

        };
    }
}
    
    
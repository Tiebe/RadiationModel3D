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

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.83d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony110() }, { 1.0d, new BetaParticle(1, 8490000.0) } } },
            { 0.17d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony106() }, { 1.0d, new AlphaParticle(4600002.09) } } },
            { 0.11d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony109() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
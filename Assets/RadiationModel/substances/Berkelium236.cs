using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium236";
        public override double halfLife { get; } = 22.0d;
        public override double atomicWeight { get; } = 236.05748d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.83d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Americium236() }, { 1.0d, new BetaParticle(1, 3750000.0) } } },
            { 0.17d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Americium232() }, { 1.0d, new AlphaParticle(8717002.09) } } },
            { 0.04d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
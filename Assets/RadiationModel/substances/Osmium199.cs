using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium199 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium199";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 198.97824d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium199() }, { 1.0d, new BetaParticle(-1, 2065000.0) } } },

        };
    }
}
    
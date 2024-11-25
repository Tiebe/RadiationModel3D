using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron45 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron45";
        public override double halfLife { get; } = 0.00189d;
        public override double atomicWeight { get; } = 45.01547d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.57d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium43() }, { 1.0d, new ProtonParticle() } } },
            { 0.43d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium45() }, { 1.0d, new BetaParticle(1, 16960000.0) } } },
            { 0.43d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium44() }, { 1.0d, new BetaParticle(1, 479662051.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium116";
        public override double halfLife { get; } = 1.3d;
        public override double atomicWeight { get; } = 115.94162d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon116() }, { 1.0d, new BetaParticle(1, 9333500.0) } } },
            { 0.03d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon115() }, { 1.0d, new BetaParticle(1, 472885551.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
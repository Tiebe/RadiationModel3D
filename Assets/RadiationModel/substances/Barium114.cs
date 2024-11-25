using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium114";
        public override double halfLife { get; } = 0.43d;
        public override double atomicWeight { get; } = 113.95071d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.991d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon114() }, { 1.0d, new BetaParticle(1, 10588000.0) } } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon113() }, { 1.0d, new ProtonParticle() } } },
            { 0.009000000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon110() }, { 1.0d, new AlphaParticle(4607002.09) } } },

        };
    }
}
    
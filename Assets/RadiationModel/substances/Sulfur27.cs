using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur27 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur27";
        public override double halfLife { get; } = 0.0155d;
        public override double atomicWeight { get; } = 27.01878d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon27() }, { 1.0d, new BetaParticle(1, 14937255.0) } } },
            { 0.023d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon26() }, { 1.0d, new BetaParticle(1, 478062551.736) }, { 1.0d, new ProtonParticle() } } },
            { 0.011000000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum25() }, { 1.0d, new BetaParticle(1, 944697088.472) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium144";
        public override double halfLife { get; } = 9.1d;
        public override double atomicWeight { get; } = 143.93927d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium144() }, { 1.0d, new BetaParticle(1, 7595000.0) }, { 0.11d, new GammaParticle(196500.0, 0.00631) }, { 0.1001d, new GammaParticle(298600.0, 0.00415) }, { 0.022000000000000002d, new GammaParticle(321500.0, 0.00386) }, { 0.0495d, new GammaParticle(475500.0, 0.00261) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
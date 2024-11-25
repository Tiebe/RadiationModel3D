using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium42 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium42";
        public override double halfLife { get; } = 0.0133d;
        public override double atomicWeight { get; } = 42.00758d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium42() }, { 1.0d, new BetaParticle(1, 16082175.0) } } },
            { 0.9440000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium41() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel48 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel48";
        public override double halfLife { get; } = 0.0021d;
        public override double atomicWeight { get; } = 48.01952d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron46() }, { 1.0d, new ProtonParticle() } } },
            { 0.3d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron47() }, { 1.0d, new BetaParticle(1, 478402051.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
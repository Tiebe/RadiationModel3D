using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium35 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium35";
        public override double halfLife { get; } = 0.0257d;
        public override double atomicWeight { get; } = 35.00557d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon35() }, { 1.0d, new BetaParticle(1, 14118650.0) } } },
            { 0.9590000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon34() }, { 1.0d, new ProtonParticle() } } },
            { 0.040999999999999995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine33() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
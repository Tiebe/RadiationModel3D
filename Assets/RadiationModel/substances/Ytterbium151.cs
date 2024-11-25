using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium151";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 150.9554d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium151() }, { 1.0d, new BetaParticle(1, 8363000.0) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium150() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium108";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 107.92938d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.51d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin108() }, { 1.0d, new BetaParticle(1, 8144000.0) } } },
            { 0.49d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin104() }, { 1.0d, new AlphaParticle(4442002.09) } } },
            { 0.024d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin107() }, { 1.0d, new BetaParticle(1, 472112051.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
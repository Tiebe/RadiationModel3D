using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen21 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen21";
        public override double halfLife { get; } = 0.084d;
        public override double atomicWeight { get; } = 21.02709d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen21() }, { 1.0d, new BetaParticle(-1, 8584000.0) }, { 0.035d, new GammaParticle(1222000.0, 0.00101) } } },
            { 0.86d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen21() }, { 1.0d, new BetaParticle(-1, 8584000.0) }, { 0.035d, new GammaParticle(1222000.0, 0.00101) } } },

        };
    }
}
    
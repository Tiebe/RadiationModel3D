using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen13 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen13";
        public override double halfLife { get; } = 0.00858d;
        public override double atomicWeight { get; } = 13.02481d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon13() }, { 1.0d, new BetaParticle(1, 9994995.35) }, { 1.9994d, new GammaParticle(511000.0, 0.00243) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon12() }, { 1.0d, new BetaParticle(1, 477304551.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
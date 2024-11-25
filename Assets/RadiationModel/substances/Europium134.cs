using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium134 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium134";
        public override double halfLife { get; } = 0.5d;
        public override double atomicWeight { get; } = 133.94654d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium134() }, { 1.0d, new BetaParticle(1, 8480000.0) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium133() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
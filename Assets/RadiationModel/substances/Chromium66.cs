using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium66 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium66";
        public override double halfLife { get; } = 0.024d;
        public override double atomicWeight { get; } = 65.97301d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese66() }, { 1.0d, new BetaParticle(-1, 5805000.0) } } },

        };
    }
}
    
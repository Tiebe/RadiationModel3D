using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium59 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium59";
        public override double halfLife { get; } = 0.74d;
        public override double atomicWeight { get; } = 58.94835d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese59() }, { 1.0d, new BetaParticle(-1, 3704700.0) } } },

        };
    }
}
    
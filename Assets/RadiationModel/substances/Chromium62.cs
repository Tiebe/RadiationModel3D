using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium62 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium62";
        public override double halfLife { get; } = 0.206d;
        public override double atomicWeight { get; } = 61.95614d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese62() }, { 1.0d, new BetaParticle(-1, 3835500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
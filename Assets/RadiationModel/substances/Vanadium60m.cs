using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium60m : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium60m";
        public override double halfLife { get; } = 0.122d;
        public override double atomicWeight { get; } = 59.96448d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium60() }, { 1.0d, new BetaParticle(-1, 6909250.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
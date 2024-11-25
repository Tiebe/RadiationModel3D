using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium60 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium60";
        public override double halfLife { get; } = 0.49d;
        public override double atomicWeight { get; } = 59.94964d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese60() }, { 1.0d, new BetaParticle(-1, 3029700.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
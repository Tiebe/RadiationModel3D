using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium63 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium63";
        public override double halfLife { get; } = 0.129d;
        public override double atomicWeight { get; } = 62.96116d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese63() }, { 1.0d, new BetaParticle(-1, 5353500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
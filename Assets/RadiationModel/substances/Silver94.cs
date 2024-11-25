using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver94 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver94";
        public override double halfLife { get; } = 0.026d;
        public override double atomicWeight { get; } = 93.94375d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium94() }, { 1.0d, new BetaParticle(1, 10254000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
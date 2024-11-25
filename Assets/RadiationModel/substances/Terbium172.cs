using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium172";
        public override double halfLife { get; } = 0.76d;
        public override double atomicWeight { get; } = 171.95739d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium172() }, { 1.0d, new BetaParticle(-1, 4035000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium167";
        public override double halfLife { get; } = 18.9d;
        public override double atomicWeight { get; } = 166.94001d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium167() }, { 1.0d, new BetaParticle(-1, 2013950.0) } } },

        };
    }
}
    
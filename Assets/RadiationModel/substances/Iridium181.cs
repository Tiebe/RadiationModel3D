using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium181 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium181";
        public override double halfLife { get; } = 294.0d;
        public override double atomicWeight { get; } = 180.95763d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium181() }, { 1.0d, new BetaParticle(1, 3527000.0) } } },

        };
    }
}
    
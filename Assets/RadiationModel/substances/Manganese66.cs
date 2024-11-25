using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese66 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese66";
        public override double halfLife { get; } = 0.065d;
        public override double atomicWeight { get; } = 65.96055d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron66() }, { 1.0d, new BetaParticle(-1, 6659000.0) } } },

        };
    }
}
    
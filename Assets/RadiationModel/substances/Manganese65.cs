using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese65 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese65";
        public override double halfLife { get; } = 0.092d;
        public override double atomicWeight { get; } = 64.95602d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron65() }, { 1.0d, new BetaParticle(-1, 5125500.0) } } },
            { 0.079d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron65() }, { 1.0d, new BetaParticle(-1, 5125500.0) } } },

        };
    }
}
    
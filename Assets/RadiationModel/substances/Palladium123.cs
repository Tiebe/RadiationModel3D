using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium123";
        public override double halfLife { get; } = 0.109d;
        public override double atomicWeight { get; } = 122.93513d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver123() }, { 1.0d, new BetaParticle(-1, 4570000.0) } } },
            { 0.013999999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver123() }, { 1.0d, new BetaParticle(-1, 4570000.0) } } },

        };
    }
}
    
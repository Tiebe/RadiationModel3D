using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium120";
        public override double halfLife { get; } = 0.132d;
        public override double atomicWeight { get; } = 119.93707d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium120() }, { 1.0d, new BetaParticle(-1, 5829800.0) } } },
            { 0.054000000000000006d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium120() }, { 1.0d, new BetaParticle(-1, 5829800.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
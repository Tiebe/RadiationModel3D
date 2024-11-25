using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium121";
        public override double halfLife { get; } = 0.151d;
        public override double atomicWeight { get; } = 120.93961d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium121() }, { 1.0d, new BetaParticle(-1, 4966000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
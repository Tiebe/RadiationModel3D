using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium126 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium126";
        public override double halfLife { get; } = 0.019d;
        public override double atomicWeight { get; } = 125.96006d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium126() }, { 1.0d, new BetaParticle(-1, 7295000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
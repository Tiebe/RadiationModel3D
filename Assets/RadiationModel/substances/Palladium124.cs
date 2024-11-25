using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium124 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium124";
        public override double halfLife { get; } = 0.038d;
        public override double atomicWeight { get; } = 123.93731d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver124() }, { 1.0d, new BetaParticle(-1, 3915000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
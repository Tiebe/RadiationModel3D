using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium111";
        public override double halfLife { get; } = 11.0d;
        public override double atomicWeight { get; } = 110.91164d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium111() }, { 1.0d, new BetaParticle(-1, 1840950.0) } } },

        };
    }
}
    
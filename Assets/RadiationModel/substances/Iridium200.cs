using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium200 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium200";
        public override double halfLife { get; } = 43.0d;
        public override double atomicWeight { get; } = 199.97684d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum200() }, { 1.0d, new BetaParticle(-1, 2514500.0) } } },

        };
    }
}
    
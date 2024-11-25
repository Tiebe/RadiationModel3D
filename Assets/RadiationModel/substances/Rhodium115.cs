using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium115";
        public override double halfLife { get; } = 0.99d;
        public override double atomicWeight { get; } = 114.92031d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium115() }, { 1.0d, new BetaParticle(-1, 3098500.0) } } },

        };
    }
}
    
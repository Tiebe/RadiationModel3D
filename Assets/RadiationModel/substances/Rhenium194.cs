using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium194 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium194";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 193.97074d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium194() }, { 1.0d, new BetaParticle(-1, 2587599.99999) } } },

        };
    }
}
    
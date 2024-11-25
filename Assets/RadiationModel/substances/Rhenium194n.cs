using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium194n : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium194n";
        public override double halfLife { get; } = 25.0d;
        public override double atomicWeight { get; } = 193.97104d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium194() }, { 1.0d, new BetaParticle(-1, 2727599.99999) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon228 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon228";
        public override double halfLife { get; } = 65.0d;
        public override double atomicWeight { get; } = 228.03783d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium228() }, { 1.0d, new BetaParticle(-1, 929500.0) } } },

        };
    }
}
    
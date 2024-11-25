using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron66 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron66";
        public override double halfLife { get; } = 0.44d;
        public override double atomicWeight { get; } = 65.94625d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt66() }, { 1.0d, new BetaParticle(-1, 3170500.0) } } },

        };
    }
}
    
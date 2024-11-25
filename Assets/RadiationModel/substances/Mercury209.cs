using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury209 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury209";
        public override double halfLife { get; } = 36.0d;
        public override double atomicWeight { get; } = 208.99076d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium209() }, { 1.0d, new BetaParticle(-1, 2517500.0) } } },

        };
    }
}
    
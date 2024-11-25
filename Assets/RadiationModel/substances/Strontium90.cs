using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium90 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium90";
        public override double halfLife { get; } = 912310729.92545d;
        public override double atomicWeight { get; } = 89.90773d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium90() }, { 1.0d, new BetaParticle(-1, 273000.0) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth210 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth210";
        public override double halfLife { get; } = 433036.8d;
        public override double atomicWeight { get; } = 209.98412d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium210() }, { 1.0d, new BetaParticle(-1, 580599.99999) } } },
            { 1.32e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium206() }, { 1.0d, new AlphaParticle(6058402.09) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium128";
        public override double halfLife { get; } = 2.429883300043584e+32d;
        public override double atomicWeight { get; } = 127.90446d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon128() }, { 1.0d, new BetaParticle(-1, 433367.0) }, { 1.0d, new BetaParticle(-1, 433367.0) } } },

        };
    }
}
    
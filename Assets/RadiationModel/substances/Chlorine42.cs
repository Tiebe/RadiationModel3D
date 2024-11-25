using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine42 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine42";
        public override double halfLife { get; } = 6.8d;
        public override double atomicWeight { get; } = 41.97334d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon42() }, { 1.0d, new BetaParticle(-1, 4796500.0) } } },

        };
    }
}
    
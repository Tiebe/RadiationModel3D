using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine45 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine45";
        public override double halfLife { get; } = 0.413d;
        public override double atomicWeight { get; } = 44.9804d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon45() }, { 1.0d, new BetaParticle(-1, 5755400.0) } } },
            { 0.24d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon45() }, { 1.0d, new BetaParticle(-1, 5755400.0) } } },

        };
    }
}
    
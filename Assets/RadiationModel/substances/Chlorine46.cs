using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine46 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine46";
        public override double halfLife { get; } = 0.232d;
        public override double atomicWeight { get; } = 45.98526d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon46() }, { 1.0d, new BetaParticle(-1, 8020650.0) } } },
            { 0.6d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon46() }, { 1.0d, new BetaParticle(-1, 8020650.0) } } },

        };
    }
}
    
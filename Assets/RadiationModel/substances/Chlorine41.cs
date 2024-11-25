using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine41 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine41";
        public override double halfLife { get; } = 38.4d;
        public override double atomicWeight { get; } = 40.97068d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon41() }, { 1.0d, new BetaParticle(-1, 2878750.0) } } },

        };
    }
}
    
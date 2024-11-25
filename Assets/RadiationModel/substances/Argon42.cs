using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon42 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon42";
        public override double halfLife { get; } = 1038222864.56408d;
        public override double atomicWeight { get; } = 41.96305d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium42() }, { 1.0d, new BetaParticle(-1, 299515.0) } } },

        };
    }
}
    
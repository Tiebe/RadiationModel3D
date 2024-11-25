using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon49 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon49";
        public override double halfLife { get; } = 0.17d;
        public override double atomicWeight { get; } = 48.98169d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium49() }, { 1.0d, new BetaParticle(-1, 6275750.0) } } },
            { 0.65d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium49() }, { 1.0d, new BetaParticle(-1, 6275750.0) } } },

        };
    }
}
    
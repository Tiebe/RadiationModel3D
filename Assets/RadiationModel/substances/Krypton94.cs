using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton94 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton94";
        public override double halfLife { get; } = 0.212d;
        public override double atomicWeight { get; } = 93.93414d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium94() }, { 1.0d, new BetaParticle(-1, 3607400.0) } } },
            { 0.0111d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium94() }, { 1.0d, new BetaParticle(-1, 3607400.0) } } },

        };
    }
}
    
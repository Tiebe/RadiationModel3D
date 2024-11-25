using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine94 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine94";
        public override double halfLife { get; } = 0.07d;
        public override double atomicWeight { get; } = 93.94885d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton94() }, { 1.0d, new BetaParticle(-1, 6849000.0) } } },
            { 0.68d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton94() }, { 1.0d, new BetaParticle(-1, 6849000.0) } } },

        };
    }
}
    
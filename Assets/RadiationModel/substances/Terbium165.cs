using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium165";
        public override double halfLife { get; } = 126.6d;
        public override double atomicWeight { get; } = 164.93496d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium165() }, { 1.0d, new BetaParticle(-1, 1511750.0) } } },

        };
    }
}
    
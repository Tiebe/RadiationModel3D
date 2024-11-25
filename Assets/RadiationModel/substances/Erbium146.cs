using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium146";
        public override double halfLife { get; } = 1.7d;
        public override double atomicWeight { get; } = 145.95242d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium146() }, { 1.0d, new BetaParticle(1, 9116500.0) } } },

        };
    }
}
    
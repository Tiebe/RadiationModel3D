using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton68 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton68";
        public override double halfLife { get; } = 0.0216d;
        public override double atomicWeight { get; } = 67.97249d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium68() }, { 1.0d, new BetaParticle(1, 14279700.0) } } },
            { 0.89d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium67() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
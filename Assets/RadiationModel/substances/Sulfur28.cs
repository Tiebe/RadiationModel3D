using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur28 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur28";
        public override double halfLife { get; } = 0.125d;
        public override double atomicWeight { get; } = 28.00437d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon28() }, { 1.0d, new BetaParticle(1, 12781398.55) } } },
            { 0.207d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon27() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
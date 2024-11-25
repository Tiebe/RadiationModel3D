using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium121";
        public override double halfLife { get; } = 1.1d;
        public override double atomicWeight { get; } = 120.94343d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium121() }, { 1.0d, new BetaParticle(1, 9025000.0) } } },
            { 0.01d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium120() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
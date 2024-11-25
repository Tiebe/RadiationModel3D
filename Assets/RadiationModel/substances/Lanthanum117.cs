using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum117 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum117";
        public override double halfLife { get; } = 0.0235d;
        public override double atomicWeight { get; } = 116.95033d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9390000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium116() }, { 1.0d, new ProtonParticle() } } },
            { 0.061d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium117() }, { 1.0d, new BetaParticle(1, 10110000.0) } } },

        };
    }
}
    
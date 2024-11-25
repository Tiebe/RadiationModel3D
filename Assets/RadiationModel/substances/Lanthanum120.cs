using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum120 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum120";
        public override double halfLife { get; } = 2.8d;
        public override double atomicWeight { get; } = 119.9382d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium120() }, { 1.0d, new BetaParticle(1, 8159500.0) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium119() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
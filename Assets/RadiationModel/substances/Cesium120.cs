using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium120";
        public override double halfLife { get; } = 61.3d;
        public override double atomicWeight { get; } = 119.92068d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine120() }, { 1.0d, new BetaParticle(1, 4929000.0) } } },
            { 2.0000000000000002e-07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon120() }, { 1.0d, new BetaParticle(1, 4141500.0) } } },
            { 7e-08d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine119() }, { 1.0d, new BetaParticle(1, 470691551.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
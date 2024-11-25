using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum121 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum121";
        public override double halfLife { get; } = 5.3d;
        public override double atomicWeight { get; } = 120.93324d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium121() }, { 1.0d, new BetaParticle(1, 7456000.0) } } },

        };
    }
}
    
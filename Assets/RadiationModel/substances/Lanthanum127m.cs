using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum127m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum127m";
        public override double halfLife { get; } = 222.0d;
        public override double atomicWeight { get; } = 126.91639d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium127() }, { 1.0d, new BetaParticle(1, 4179000.0) } } },

        };
    }
}
    
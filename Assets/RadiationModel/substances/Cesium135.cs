using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium135";
        public override double halfLife { get; } = 72580929741561.6d;
        public override double atomicWeight { get; } = 134.90598d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium135() }, { 1.0d, new BetaParticle(-1, 134325.0) } } },

        };
    }
}
    
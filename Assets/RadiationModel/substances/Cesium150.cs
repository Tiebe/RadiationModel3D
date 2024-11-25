using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium150";
        public override double halfLife { get; } = 0.084d;
        public override double atomicWeight { get; } = 149.95902d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium150() }, { 1.0d, new BetaParticle(-1, 5860000.0) } } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium150() }, { 1.0d, new BetaParticle(-1, 5860000.0) } } },

        };
    }
}
    
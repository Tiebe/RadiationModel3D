using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium147";
        public override double halfLife { get; } = 0.2295d;
        public override double atomicWeight { get; } = 146.94426d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium147() }, { 1.0d, new BetaParticle(-1, 4172000.0) } } },
            { 0.285d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium147() }, { 1.0d, new BetaParticle(-1, 4172000.0) } } },

        };
    }
}
    
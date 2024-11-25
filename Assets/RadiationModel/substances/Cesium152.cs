using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium152";
        public override double halfLife { get; } = 0.05d;
        public override double atomicWeight { get; } = 151.96873d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium152() }, { 1.0d, new BetaParticle(-1, 6240000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    
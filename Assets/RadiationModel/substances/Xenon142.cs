using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon142 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon142";
        public override double halfLife { get; } = 1.23d;
        public override double atomicWeight { get; } = 141.92997d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium142() }, { 1.0d, new BetaParticle(-1, 2642700.0) } } },
            { 0.0021d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium142() }, { 1.0d, new BetaParticle(-1, 2642700.0) } } },

        };
    }
}
    
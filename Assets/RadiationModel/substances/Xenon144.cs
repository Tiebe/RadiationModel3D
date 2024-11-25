using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon144 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon144";
        public override double halfLife { get; } = 1.15d;
        public override double atomicWeight { get; } = 143.93895d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium144() }, { 1.0d, new BetaParticle(-1, 3199500.0) } } },

        };
    }
}
    
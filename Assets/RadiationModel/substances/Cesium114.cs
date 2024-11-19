using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium114";
        public override double halfLife { get; } = 0.57d;
        public override double atomicWeight { get; } = 113.94129d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 12396000.0), new Xenon114() } },
            { 0.00017999999999999998d, new List<RadioactiveSubstance> { new AlphaParticle(4377002.09), new Iodine110() } },

        };
    }
}
    
    
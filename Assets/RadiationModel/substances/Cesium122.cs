using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium122 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium122";
        public override double halfLife { get; } = 21.18d;
        public override double atomicWeight { get; } = 121.91611d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7215000.0), new Xenon122() } },

        };
    }
}
    
    
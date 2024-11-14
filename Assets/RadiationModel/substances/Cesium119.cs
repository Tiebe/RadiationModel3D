using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium119 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium119";
        public override double halfLife { get; } = 43.0d;
        public override double atomicWeight { get; } = 118.92238d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6489000.0), new Xenon119() } },

        };
    }
}
    
    
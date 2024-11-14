using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium130";
        public override double halfLife { get; } = 1752.6d;
        public override double atomicWeight { get; } = 129.90671d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9840000000000001d, new List<RadioactiveSubstance> { new BetaParticle(1, 2980474.0), new Xenon130() } },
            { 0.016d, new List<RadioactiveSubstance> { new BetaParticle(-1, 356780.0), new Barium130() } },

        };
    }
}
    
    
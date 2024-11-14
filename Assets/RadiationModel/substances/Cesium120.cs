using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium120";
        public override double halfLife { get; } = 60.4d;
        public override double atomicWeight { get; } = 119.92068d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8283000.0), new Xenon120() } },

        };
    }
}
    
    
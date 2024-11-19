using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium134m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium134m";
        public override double halfLife { get; } = 10483.2d;
        public override double atomicWeight { get; } = 133.90687d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00894, 138744.0), new Cesium134() } },

        };
    }
}
    
    
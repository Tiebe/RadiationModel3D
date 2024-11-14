using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium122p : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium122p";
        public override double halfLife { get; } = 0.36d;
        public override double atomicWeight { get; } = 121.91625d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00954), new Cesium122() } },

        };
    }
}
    
    
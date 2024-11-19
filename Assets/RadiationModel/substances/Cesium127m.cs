using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium127m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium127m";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 126.9079d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((452000.0, 0.00274)), new Cesium127() } },

        };
    }
}
    
    
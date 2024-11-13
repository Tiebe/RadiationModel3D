
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium135m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium135m";
        public override double halfLife { get; } = 3180.0d;
        public override double atomicWeight { get; } = 134.90773d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Cesium135() } },

        };
    }
}
    
    
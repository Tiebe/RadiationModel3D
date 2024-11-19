using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium140m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium140m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 139.9173d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.08856, 14000.0), new Cesium140() } },

        };
    }
}
    
    
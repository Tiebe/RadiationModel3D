using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium129m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium129m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 128.90668d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00216), new Cesium129() } },

        };
    }
}
    
    
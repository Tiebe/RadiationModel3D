using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium123m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium123m";
        public override double halfLife { get; } = 1.64d;
        public override double atomicWeight { get; } = 122.91316d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((156000.0, 0.00795)), new Cesium123() } },

        };
    }
}
    
    
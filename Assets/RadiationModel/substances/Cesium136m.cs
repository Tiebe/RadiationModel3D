using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium136m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium136m";
        public override double halfLife { get; } = 17.5d;
        public override double atomicWeight { get; } = 135.90787d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
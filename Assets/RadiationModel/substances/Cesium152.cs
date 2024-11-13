
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium152";
        public override double halfLife { get; } = 0.017d;
        public override double atomicWeight { get; } = 151.96873d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
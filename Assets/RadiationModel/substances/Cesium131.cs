
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium131";
        public override double halfLife { get; } = 837129.6d;
        public override double atomicWeight { get; } = 130.90547d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Xenon131() } },

        };
    }
}
    
    
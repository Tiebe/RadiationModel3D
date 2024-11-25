using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium126n : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium126n";
        public override double halfLife { get; } = 0.00017d;
        public override double atomicWeight { get; } = 125.91009d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
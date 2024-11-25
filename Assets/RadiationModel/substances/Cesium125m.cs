using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium125m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium125m";
        public override double halfLife { get; } = 0.0009d;
        public override double atomicWeight { get; } = 124.91001d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium125() } } },

        };
    }
}
    
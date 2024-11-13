
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium128";
        public override double halfLife { get; } = 209952.0d;
        public override double atomicWeight { get; } = 127.90835d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Cesium128() } },

        };
    }
}
    
    
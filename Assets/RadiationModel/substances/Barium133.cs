using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium133";
        public override double halfLife { get; } = 332544004.4808d;
        public override double atomicWeight { get; } = 132.90601d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Cesium133() } },

        };
    }
}
    
    
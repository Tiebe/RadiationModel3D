
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine106 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine106";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 105.95352d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
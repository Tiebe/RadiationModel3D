
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum195 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum195";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 194.96479d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
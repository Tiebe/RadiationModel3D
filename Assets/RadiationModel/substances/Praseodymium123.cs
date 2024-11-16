using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium123";
        public override double halfLife { get; } = 0.8d;
        public override double atomicWeight { get; } = 122.94608d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
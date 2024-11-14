using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium122 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium122";
        public override double halfLife { get; } = 0.5d;
        public override double atomicWeight { get; } = 121.95193d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
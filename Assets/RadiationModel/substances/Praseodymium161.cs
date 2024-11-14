using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium161";
        public override double halfLife { get; } = 0.09d;
        public override double atomicWeight { get; } = 160.96512d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
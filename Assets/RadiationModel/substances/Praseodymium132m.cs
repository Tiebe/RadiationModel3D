using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium132m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium132m";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 131.91927d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
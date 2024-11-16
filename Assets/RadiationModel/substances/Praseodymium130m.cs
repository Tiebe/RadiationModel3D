using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium130m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium130m";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 129.92369d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
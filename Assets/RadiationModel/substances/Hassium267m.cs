
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium267m : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium267m";
        public override double halfLife { get; } = 0.00099d;
        public override double atomicWeight { get; } = 267.13172d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
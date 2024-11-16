using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum165m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum165m";
        public override double halfLife { get; } = 30.0d;
        public override double atomicWeight { get; } = 164.95081d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
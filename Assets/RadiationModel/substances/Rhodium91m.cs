
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium91m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium91m";
        public override double halfLife { get; } = 1.8d;
        public override double atomicWeight { get; } = 90.9373d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
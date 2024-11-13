
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium284 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium284";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 284.17388d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
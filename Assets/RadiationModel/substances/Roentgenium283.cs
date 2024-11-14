using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium283 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium283";
        public override double halfLife { get; } = 120.0d;
        public override double atomicWeight { get; } = 283.1711d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
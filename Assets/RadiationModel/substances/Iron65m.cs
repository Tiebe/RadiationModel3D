using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron65m : RadioactiveSubstance
    {
        public override string name { get; } = "Iron65m";
        public override double halfLife { get; } = 1.12d;
        public override double atomicWeight { get; } = 64.94544d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
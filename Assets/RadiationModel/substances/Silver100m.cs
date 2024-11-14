using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver100m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver100m";
        public override double halfLife { get; } = 134.4d;
        public override double atomicWeight { get; } = 99.91613d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    

using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver121m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver121m";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 120.92015d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
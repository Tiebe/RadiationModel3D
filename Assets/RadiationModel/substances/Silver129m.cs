using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver129m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver129m";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 128.94434d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
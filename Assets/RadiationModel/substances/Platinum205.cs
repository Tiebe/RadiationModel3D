using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum205 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum205";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 204.98624d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
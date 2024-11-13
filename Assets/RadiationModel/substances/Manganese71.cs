
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese71 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese71";
        public override double halfLife { get; } = 0.016d;
        public override double atomicWeight { get; } = 70.98216d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
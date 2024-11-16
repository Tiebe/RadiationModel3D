using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium265 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium265";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 265.13593d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
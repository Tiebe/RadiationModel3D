using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium279 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium279";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 279.15844d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
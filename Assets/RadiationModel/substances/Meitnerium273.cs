using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium273 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium273";
        public override double halfLife { get; } = 0.8d;
        public override double atomicWeight { get; } = 273.14469d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
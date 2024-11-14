using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium276 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium276";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 276.14835d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
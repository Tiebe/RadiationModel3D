using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium274 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium274";
        public override double halfLife { get; } = 0.5d;
        public override double atomicWeight { get; } = 274.14322d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium271 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium271";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 271.13708d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
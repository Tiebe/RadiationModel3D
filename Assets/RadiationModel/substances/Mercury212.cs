
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury212 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury212";
        public override double halfLife { get; } = 30.0d;
        public override double atomicWeight { get; } = 212.00324d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
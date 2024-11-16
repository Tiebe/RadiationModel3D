using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium273 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium273";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 273.14029d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
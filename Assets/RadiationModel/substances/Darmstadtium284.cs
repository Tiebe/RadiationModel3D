
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium284 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium284";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 284.17119d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
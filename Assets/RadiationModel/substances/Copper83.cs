
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper83 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper83";
        public override double halfLife { get; } = 0.021d;
        public override double atomicWeight { get; } = 82.97811d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
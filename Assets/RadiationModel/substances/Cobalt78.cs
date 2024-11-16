using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt78 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt78";
        public override double halfLife { get; } = 0.011d;
        public override double atomicWeight { get; } = 77.98355d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
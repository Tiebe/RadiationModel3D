using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium140";
        public override double halfLife { get; } = 0.7d;
        public override double atomicWeight { get; } = 139.95402d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
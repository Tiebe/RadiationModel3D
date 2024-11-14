using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium176 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium176";
        public override double halfLife { get; } = 0.44d;
        public override double atomicWeight { get; } = 175.96392d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
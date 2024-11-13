
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium271 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium271";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 271.14074d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
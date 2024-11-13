
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium104";
        public override double halfLife { get; } = 0.035d;
        public override double atomicWeight { get; } = 103.97053d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
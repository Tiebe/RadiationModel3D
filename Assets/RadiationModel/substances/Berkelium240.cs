
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium240 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium240";
        public override double halfLife { get; } = 288.0d;
        public override double atomicWeight { get; } = 240.05975d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
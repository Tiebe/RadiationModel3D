using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium237";
        public override double halfLife { get; } = 120.0d;
        public override double atomicWeight { get; } = 237.05712d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
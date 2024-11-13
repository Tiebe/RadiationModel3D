
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium248 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium248";
        public override double halfLife { get; } = 284012568.0d;
        public override double atomicWeight { get; } = 248.07314d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
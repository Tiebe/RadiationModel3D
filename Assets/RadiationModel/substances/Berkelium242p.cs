using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium242p : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium242p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 242.06216d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
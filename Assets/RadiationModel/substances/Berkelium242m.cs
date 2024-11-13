
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium242m : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium242m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 242.06414d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    
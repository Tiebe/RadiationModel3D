
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum119 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum119";
        public override double halfLife { get; } = 0.012d;
        public override double atomicWeight { get; } = 118.97147d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
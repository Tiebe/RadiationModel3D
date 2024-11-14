using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum81 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum81";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 80.96623d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
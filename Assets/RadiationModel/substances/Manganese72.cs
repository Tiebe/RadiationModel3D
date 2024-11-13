
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese72 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese72";
        public override double halfLife { get; } = 0.012d;
        public override double atomicWeight { get; } = 71.98801d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
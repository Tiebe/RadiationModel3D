using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese73 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese73";
        public override double halfLife { get; } = 0.012d;
        public override double atomicWeight { get; } = 72.99281d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
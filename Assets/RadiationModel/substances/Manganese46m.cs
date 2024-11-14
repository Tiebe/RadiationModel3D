using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese46m : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese46m";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 45.98683d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
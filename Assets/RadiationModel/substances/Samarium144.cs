using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium144";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 143.91201d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
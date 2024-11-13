
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon33 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon33";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 33.04952d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
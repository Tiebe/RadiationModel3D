using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium239";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 239.06066d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium159m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium159m";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 158.94674d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
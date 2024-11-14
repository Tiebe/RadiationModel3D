using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium133m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium133m";
        public override double halfLife { get; } = 3.5d;
        public override double atomicWeight { get; } = 132.93869d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
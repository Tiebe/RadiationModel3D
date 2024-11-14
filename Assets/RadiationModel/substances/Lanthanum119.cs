using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum119 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum119";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 118.94093d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
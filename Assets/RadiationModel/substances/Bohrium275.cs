using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium275 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium275";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 275.14577d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
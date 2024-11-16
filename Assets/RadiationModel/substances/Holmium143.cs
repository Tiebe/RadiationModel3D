using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium143";
        public override double halfLife { get; } = 0.3d;
        public override double atomicWeight { get; } = 142.95486d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
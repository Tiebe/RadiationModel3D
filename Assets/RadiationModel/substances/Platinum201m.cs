using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum201m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum201m";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 200.97543d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
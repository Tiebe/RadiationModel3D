using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum207 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum207";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 206.99556d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
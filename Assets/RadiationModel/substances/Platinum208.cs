
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum208 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum208";
        public override double halfLife { get; } = 0.22d;
        public override double atomicWeight { get; } = 207.99946d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
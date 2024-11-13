
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold208 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold208";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 207.99366d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
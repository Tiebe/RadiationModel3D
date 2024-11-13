
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold182m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold182m";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 181.96975d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
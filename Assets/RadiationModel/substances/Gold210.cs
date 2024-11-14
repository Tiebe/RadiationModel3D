using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold210 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold210";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 210.00288d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
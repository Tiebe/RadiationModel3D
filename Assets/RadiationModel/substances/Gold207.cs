using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold207 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold207";
        public override double halfLife { get; } = 3.0d;
        public override double atomicWeight { get; } = 206.98858d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
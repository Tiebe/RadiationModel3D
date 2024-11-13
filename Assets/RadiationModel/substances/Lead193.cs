
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead193 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead193";
        public override double halfLife { get; } = 240.0d;
        public override double atomicWeight { get; } = 192.97614d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
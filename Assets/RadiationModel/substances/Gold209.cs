
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold209 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold209";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 208.99761d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
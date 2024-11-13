
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium265 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium265";
        public override double halfLife { get; } = 900.0d;
        public override double atomicWeight { get; } = 265.1185d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
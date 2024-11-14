using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium264 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium264";
        public override double halfLife { get; } = 180.0d;
        public override double atomicWeight { get; } = 264.1173d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
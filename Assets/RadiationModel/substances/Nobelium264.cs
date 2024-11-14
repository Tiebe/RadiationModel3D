using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium264 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium264";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 264.11273d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
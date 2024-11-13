
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium210m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium210m";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 209.99136d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
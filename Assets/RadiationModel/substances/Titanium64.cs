using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium64 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium64";
        public override double halfLife { get; } = 0.005d;
        public override double atomicWeight { get; } = 63.99841d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
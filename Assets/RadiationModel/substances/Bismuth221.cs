
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth221 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth221";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 221.02598d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
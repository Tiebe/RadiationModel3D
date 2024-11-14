using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium279 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium279";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 279.17119d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
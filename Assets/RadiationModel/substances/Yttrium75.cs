using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium75 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium75";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 74.96584d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
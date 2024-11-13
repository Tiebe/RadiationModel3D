
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth222 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth222";
        public override double halfLife { get; } = 3.0d;
        public override double atomicWeight { get; } = 222.03108d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth214m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth214m";
        public override double halfLife { get; } = 93.0d;
        public override double atomicWeight { get; } = 213.99929d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
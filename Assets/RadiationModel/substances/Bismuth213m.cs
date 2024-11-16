using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth213m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth213m";
        public override double halfLife { get; } = 168.0d;
        public override double atomicWeight { get; } = 212.99584d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth188m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth188m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 187.99235d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
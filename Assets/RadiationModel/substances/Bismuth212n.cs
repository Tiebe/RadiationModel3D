
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth212n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth212n";
        public override double halfLife { get; } = 420.0d;
        public override double atomicWeight { get; } = 211.99287d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
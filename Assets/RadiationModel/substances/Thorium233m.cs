
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium233m : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium233m";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 233.04159d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
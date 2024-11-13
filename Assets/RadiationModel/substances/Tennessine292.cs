
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tennessine292 : RadioactiveSubstance
    {
        public override string name { get; } = "Tennessine292";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 292.20786d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
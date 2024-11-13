
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tennessine291 : RadioactiveSubstance
    {
        public override string name { get; } = "Tennessine291";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 291.20574d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
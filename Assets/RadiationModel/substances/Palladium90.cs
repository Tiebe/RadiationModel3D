
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium90 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium90";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 89.95737d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
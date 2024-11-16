using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum40 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum40";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 40.03094d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
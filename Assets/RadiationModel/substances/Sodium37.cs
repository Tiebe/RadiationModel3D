
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium37 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium37";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 37.05704d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
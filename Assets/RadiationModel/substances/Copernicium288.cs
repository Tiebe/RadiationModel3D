
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium288 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium288";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 288.1835d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
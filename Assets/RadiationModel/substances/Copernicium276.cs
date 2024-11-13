
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium276 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium276";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 276.16142d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
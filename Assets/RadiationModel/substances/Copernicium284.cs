
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium284 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium284";
        public override double halfLife { get; } = 0.102d;
        public override double atomicWeight { get; } = 284.17437d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    
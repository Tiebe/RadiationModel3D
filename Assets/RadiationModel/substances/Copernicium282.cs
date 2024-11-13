
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium282 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium282";
        public override double halfLife { get; } = 0.0011d;
        public override double atomicWeight { get; } = 282.17051d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    
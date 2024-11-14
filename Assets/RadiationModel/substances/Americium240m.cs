using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium240m : RadioactiveSubstance
    {
        public override string name { get; } = "Americium240m";
        public override double halfLife { get; } = 0.00094d;
        public override double atomicWeight { get; } = 240.05852d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium243m : RadioactiveSubstance
    {
        public override string name { get; } = "Americium243m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 243.06385d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    
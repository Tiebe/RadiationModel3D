using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium250m : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium250m";
        public override double halfLife { get; } = 4e-05d;
        public override double atomicWeight { get; } = 250.0887d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    
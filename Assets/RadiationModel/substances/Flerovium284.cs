using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Flerovium284 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium284";
        public override double halfLife { get; } = 0.0031d;
        public override double atomicWeight { get; } = 284.18119d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium235n : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium235n";
        public override double halfLife { get; } = 0.0036d;
        public override double atomicWeight { get; } = 235.04661d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    
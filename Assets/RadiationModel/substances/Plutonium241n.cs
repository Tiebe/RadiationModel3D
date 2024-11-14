using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium241n : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium241n";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 241.05922d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    
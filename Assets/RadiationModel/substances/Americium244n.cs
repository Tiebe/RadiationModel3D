using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium244n : RadioactiveSubstance
    {
        public override string name { get; } = "Americium244n";
        public override double halfLife { get; } = 0.0009d;
        public override double atomicWeight { get; } = 244.06643d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    
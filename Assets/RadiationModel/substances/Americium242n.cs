
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium242n : RadioactiveSubstance
    {
        public override string name { get; } = "Americium242n";
        public override double halfLife { get; } = 0.014d;
        public override double atomicWeight { get; } = 242.06191d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    

using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium66 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium66";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 65.99324d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
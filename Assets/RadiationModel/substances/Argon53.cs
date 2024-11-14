using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon53 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon53";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 53.00729d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
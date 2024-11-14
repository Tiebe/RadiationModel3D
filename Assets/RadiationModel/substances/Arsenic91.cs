using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic91 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic91";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 90.96082d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
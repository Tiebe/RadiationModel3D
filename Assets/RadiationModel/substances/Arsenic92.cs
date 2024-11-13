
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic92 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic92";
        public override double halfLife { get; } = 0.045d;
        public override double atomicWeight { get; } = 91.96739d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
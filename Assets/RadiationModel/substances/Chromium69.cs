
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium69 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium69";
        public override double halfLife { get; } = 0.006d;
        public override double atomicWeight { get; } = 68.98966d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
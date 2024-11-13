
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium67 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium67";
        public override double halfLife { get; } = 0.011d;
        public override double atomicWeight { get; } = 66.97931d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
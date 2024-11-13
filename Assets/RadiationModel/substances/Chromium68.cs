
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium68 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium68";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 67.98316d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
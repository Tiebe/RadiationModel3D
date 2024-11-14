using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium51 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium51";
        public override double halfLife { get; } = 2393409.6d;
        public override double atomicWeight { get; } = 50.94477d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Vanadium51() } },

        };
    }
}
    
    
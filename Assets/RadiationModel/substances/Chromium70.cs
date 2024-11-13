
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium70 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium70";
        public override double halfLife { get; } = 0.006d;
        public override double atomicWeight { get; } = 69.99395d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
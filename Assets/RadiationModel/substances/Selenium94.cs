
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium94";
        public override double halfLife { get; } = 0.05d;
        public override double atomicWeight { get; } = 93.96049d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
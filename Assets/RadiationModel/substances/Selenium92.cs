using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium92 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium92";
        public override double halfLife { get; } = 0.09d;
        public override double atomicWeight { get; } = 91.94984d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
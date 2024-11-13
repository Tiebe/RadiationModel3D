
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium64 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium64";
        public override double halfLife { get; } = 0.0226d;
        public override double atomicWeight { get; } = 63.97116d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
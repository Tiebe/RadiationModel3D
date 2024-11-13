
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium273 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium273";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 273.1534d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
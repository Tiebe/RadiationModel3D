
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium276 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium276";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 276.15823d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
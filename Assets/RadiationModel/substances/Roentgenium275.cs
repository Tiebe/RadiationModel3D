using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium275 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium275";
        public override double halfLife { get; } = 0.005d;
        public override double atomicWeight { get; } = 275.15609d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
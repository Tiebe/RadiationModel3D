
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium276 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium276";
        public override double halfLife { get; } = 0.016d;
        public override double atomicWeight { get; } = 276.15302d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
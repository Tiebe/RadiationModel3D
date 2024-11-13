
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron11j : RadioactiveSubstance
    {
        public override string name { get; } = "Boron11j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 11.04534d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
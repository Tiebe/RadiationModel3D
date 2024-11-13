
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium279p : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium279p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 279.16292d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
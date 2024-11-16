using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury199 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury199";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 198.96828d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
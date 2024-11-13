
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron56 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron56";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 55.93494d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
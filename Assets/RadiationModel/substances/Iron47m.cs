
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron47m : RadioactiveSubstance
    {
        public override string name { get; } = "Iron47m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 46.99317d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
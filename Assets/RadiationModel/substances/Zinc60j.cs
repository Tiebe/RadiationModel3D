using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc60j : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc60j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 59.94975d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
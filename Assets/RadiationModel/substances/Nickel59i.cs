using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel59i : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel59i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 58.94223d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
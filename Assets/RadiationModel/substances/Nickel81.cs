using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel81 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel81";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 80.98273d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
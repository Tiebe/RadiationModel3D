using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron75 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron75";
        public override double halfLife { get; } = 0.009d;
        public override double atomicWeight { get; } = 74.98422d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron52j : RadioactiveSubstance
    {
        public override string name { get; } = "Iron52j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 51.9573d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
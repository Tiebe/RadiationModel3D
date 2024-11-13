
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium143";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 142.90982d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
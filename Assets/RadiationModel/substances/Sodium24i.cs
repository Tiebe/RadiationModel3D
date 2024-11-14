using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium24i : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium24i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 23.99737d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
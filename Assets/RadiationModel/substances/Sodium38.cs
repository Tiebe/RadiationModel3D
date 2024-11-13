
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium38 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium38";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 38.06646d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
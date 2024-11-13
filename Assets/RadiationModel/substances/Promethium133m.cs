
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium133m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium133m";
        public override double halfLife { get; } = 8.0d;
        public override double atomicWeight { get; } = 132.92992d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
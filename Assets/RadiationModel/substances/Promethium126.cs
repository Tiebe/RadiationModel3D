
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium126 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium126";
        public override double halfLife { get; } = 0.5d;
        public override double atomicWeight { get; } = 125.95733d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
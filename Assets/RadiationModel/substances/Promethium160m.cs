using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium160m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium160m";
        public override double halfLife { get; } = 0.7d;
        public override double atomicWeight { get; } = 159.94342d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
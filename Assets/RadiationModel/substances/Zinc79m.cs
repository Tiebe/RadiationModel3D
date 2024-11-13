
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc79m : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc79m";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 78.94382d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur49 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur49";
        public override double halfLife { get; } = 0.004d;
        public override double atomicWeight { get; } = 49.02189d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon21i : RadioactiveSubstance
    {
        public override string name { get; } = "Neon21i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 21.00336d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus28i : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus28i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 27.99865d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
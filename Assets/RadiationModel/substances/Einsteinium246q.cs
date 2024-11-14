using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium246q : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium246q";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 246.07322d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
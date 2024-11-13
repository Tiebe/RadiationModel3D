
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium257p : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium257p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 257.09721d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
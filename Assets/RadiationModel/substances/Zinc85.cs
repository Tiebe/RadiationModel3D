
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc85 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc85";
        public override double halfLife { get; } = 0.04d;
        public override double atomicWeight { get; } = 84.97305d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
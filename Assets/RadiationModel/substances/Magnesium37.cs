using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium37 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium37";
        public override double halfLife { get; } = 0.008d;
        public override double atomicWeight { get; } = 37.03028d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    
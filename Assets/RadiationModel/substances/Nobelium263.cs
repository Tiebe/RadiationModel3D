
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium263 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium263";
        public override double halfLife { get; } = 1200.0d;
        public override double atomicWeight { get; } = 263.11071d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    